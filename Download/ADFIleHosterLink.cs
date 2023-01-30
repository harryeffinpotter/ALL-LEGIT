using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_LEGIT.Download
{
    public class ADFilerHosterLink
    {

        public string SourceLink { get; set; }

        public string Error { get; set; }  
       
        public string ConvertedLink { get; set; }

        public long FileSize { get; set; }

        public int ID { get; set; }
        
        public ADFilerHosterLink(long ID)
        {
            string sourceLink = this.SourceLink;
            
        }
    }
}
