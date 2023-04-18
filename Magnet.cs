using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Graph.Groups.Item.Conversations.Item.Threads.Item.Posts.Item.InReplyTo;

namespace ALL_LEGIT
{
    class Magnet
    {
        public string name { get; private set; }
        public string magnetLink { get; set; }
        public string updatesLink { get; set; }
        public string status { get; set; }
        public int internalID { get; set; }
        public List<string> links { get; set; }

        public Magnet() { }

        public Magnet(int internalID, string name, string updatesLink) 
        { 
            var magnet = new Magnet();
            magnet.name = name;
            magnet.internalID = internalID;
            magnet.updatesLink = updatesLink;
        }
    }
}