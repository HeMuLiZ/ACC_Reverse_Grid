using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACC_Reverse_Grid_App
{
    class Qualifying
    {
        FileReader filereader = new FileReader();
        Sessions sessions = new Sessions();
        public void RemoveDefauldGridPositions()
        {
            string path = Directory.GetCurrentDirectory() + @"\cfg\entrylist.json";

            var entrylistObject = filereader.Readfile(path);

            var entries = entrylistObject.SelectToken("$.entries");

            //every defaultGridPosition to -1
            for (int i = 0; i < entries.Count(); i++)
            {
                entries[i]["defaultGridPosition"] = -1;
                string entrylist = Newtonsoft.Json.JsonConvert.SerializeObject(entrylistObject, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(@"cfg\entrylist.json", entrylist, Encoding.Unicode);
            }
            sessions.AddQualifying();
        }
}
}
