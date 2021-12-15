using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACC_Reverse_Grid_App
{
    public class Settings
    {
        private static Settings instance = null;
        public static Settings Instance
        {
            get
            {
                if (instance == null)
                    instance = new Settings();
                return instance;
            }
        }
        public bool DevMode { get; set; }
        public int PracticeMinutes { get; set; }
        public int LowDNF { get; set; }
        public int HighDNF { get; set; }
        public bool DNFsBackOfGrid { get; set; }
        public bool UseDnfSettings { get; set; }
    }
}
