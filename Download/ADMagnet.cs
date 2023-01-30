using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_LEGIT.Download
{
    public class ADMagnet
    {

        public string MagnetLink { get; set; }

        public int MagnetID { get; set; }
        public string[] ConvertedMagnetLinks { get; set; }

        public long TotalSize { get; set; }

        public long DownloadSpeed { get; set; } 

        public long UploadSpeed{ get; set; }

        public int Seeders { get; set; }

        public Files MagnetFiles { get; set; }

        public long DownloadedBytes { get; set; }  

        public long UploadedBytes { get; set; }
 
        public string DownloadFolder { get; set; } = string.Empty;

        public string Status { get; set; }
        

    }

    public class Files
    {
        public string FileName { get; set; }

       public string[] FolderPath { get; set; }
    }

}
