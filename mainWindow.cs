using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ALL_LEGIT
{
    public partial class MainWindow : Form
    {
        public static string APIKEY;
        public static string apiNAME;

        public MainWindow()
        {
            InitializeComponent();

        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            await ConnectViaAPIAsync();
            while (!loginsuccess)
            {
                connectedLbl.Text = "Not Connected";
                connectedLbl.ForeColor = Color.HotPink;
            }
            if (loginsuccess)
            {
                connectedLbl.Text = "Connected!";
                connectedLbl.ForeColor = Color.LightGreen;
            }
        }

        public static dynamic getJson(string requestURL)
        {
            var client = new RestClient($"https://api.alldebrid.com/v4/");
            var request = new RestRequest(requestURL, Method.Get);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var queryResult = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);
            return obj;
        }
        public static bool loginsuccess = false;
        public static async Task ConnectViaAPIAsync()
        {
 
            apiNAME = Properties.Settings.Default.ApiNAME;
            APIKEY = Properties.Settings.Default.ApiKEY;
            if (!String.IsNullOrWhiteSpace(apiNAME) || !String.IsNullOrWhiteSpace(APIKEY))
            {
                apiNAME = Properties.Settings.Default.ApiNAME;
                APIKEY = Properties.Settings.Default.ApiKEY;
                var auth = getJson($"user?agent={apiNAME}&apikey={APIKEY}");
                if (!auth.ToString().Contains("AUTH"))
                {
                    loginsuccess = true;
                }
                else
                {
                    MessageBox.Show("Previously set API key no longer working... you must reconnect!");
                }
            }

            if (!loginsuccess)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 1000);
                apiNAME = $"AllLegit{randomNumber}";
                Properties.Settings.Default.ApiNAME = apiNAME;
                Properties.Settings.Default.Save();
                var obj = getJson($"pin/get?agent={apiNAME}");

                Process.Start(obj.data.user_url.ToString());
                string CheckURL = obj.data.check_url.ToString();
                obj = getJson(CheckURL);
                bool Activated = false;
                Activated = bool.Parse(obj.data.activated.ToString());
                while (!Activated)
                {
                    obj = getJson(CheckURL);
                    Activated = bool.Parse(obj.data.activated.ToString());
                    await Task.Delay(100);
                }

                if (Activated)
                {
                    obj = getJson(CheckURL);
                    APIKEY = obj.data.apikey.ToString();
                    Properties.Settings.Default.ApiKEY = APIKEY;
                    Properties.Settings.Default.Save();
                }

                var auth = getJson($"user?agent={apiNAME}&apikey={APIKEY}");
                if (!auth.ToString().Contains("AUTH"))
                {
                    loginsuccess = true;
                }
                else
                {
                    MessageBox.Show("Previously set API key no longer working... you must reconnect!");
                }
            }
        }
    }
}
