using System.Collections.Generic;
using System.ComponentModel;

namespace Sometimes_EventNoRP
{
    public class Config
    {
        public bool Enabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        
        
        [Description("Customize your message at the beginning of the round RP!")]
        public string MessageRP { get; set; } = "<color=#80fa99><b>Game RP. Good luck !</b></color>";
        
        [Description("Customize your message at the beginning of the round NoRP!")]
        public string MessageNoRP { get; set; } = "<color=#3E48C7><b>Game NoRP. Good luck !</b></color>";
        
        [Description("Customize your chance percentage for a NoRP game!")]
        public int NoRPPercentage { get; set; } = 25;
        
        [Description("Customize your broadcast duration!")]
        public ushort BroadcastDuration { get; set; } = 10;
    }
}