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
        public string endPoint {  get; set; }   

        public MainWindow()
        {
            InitializeComponent();

        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {

            var client = new RestClient("https://api.alldebrid.com/");

            apiNAME = Properties.Settings.Default.ApiNAME;
            APIKEY = Properties.Settings.Default.ApiKEY;
            if (String.IsNullOrWhiteSpace(apiNAME) || String.IsNullOrWhiteSpace(APIKEY))
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 1000);
                apiNAME = $"AllLegit{randomNumber}";
                Properties.Settings.Default.ApiNAME = apiNAME;
                Properties.Settings.Default.Save();


                var request = new RestRequest("v4/pin/get?agent=AllLegit", Method.Get);


                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };

                var queryResult = client.Execute(request);
                var obj = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);
                Process.Start(obj.data.user_url.ToString());
                string CheckURL = obj.data.check_url.ToString();
                request = new RestRequest(CheckURL, Method.Get);
                queryResult = client.Execute(request);
                obj = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);
                bool Activated = false;
                Activated = bool.Parse(obj.data.activated.ToString());
                while (!Activated)
                {
                    request = new RestRequest(CheckURL, Method.Get);
                    queryResult = client.Execute(request);
                    obj = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);
                    Activated = bool.Parse(obj.data.activated.ToString());
                    await Task.Delay(100);
                }

                if (Activated)
                {
                    request = new RestRequest(CheckURL, Method.Get);
                    queryResult = client.Execute(request);
                    obj = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);
                    APIKEY = obj.data.apikey.ToString();
                    Properties.Settings.Default.ApiKEY = APIKEY;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                apiNAME = Properties.Settings.Default.ApiNAME;
                APIKEY = Properties.Settings.Default.ApiKEY;
            }

        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.A) && e.KeyChar.Equals(Keys.Alt))
            {

            }
        }

    }
}
