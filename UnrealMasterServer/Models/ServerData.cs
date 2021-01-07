using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnrealMasterServer.Models
{
    public class ServerData
    {
        // Database fields
        public int ServerId { get; set; }
        public string IpAddress { get; set; }
        public string ServerName { get; set; }
        public string MapName { get; set; }
        public int CurrentPlayers { get; set; }
        public int MaxPlayers { get; set; }
    }
}