using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ACC_Reverse_Grid_App
{
    class Entrylist
    {
        FileReader fileReader = new FileReader();
        Sessions sessions = new Sessions();

        public void SetGrid(List<Tuple<string, string>> drivers)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\cfg\entrylist.json";
                int playerIndex = -1;

                var entrylistobject = fileReader.Readfile(path);

                foreach (JObject entry in entrylistobject.SelectToken("$.entries"))
                {
                    playerIndex = playerIndex + 1;

                    for (int i = 0; i < drivers.Count(); i++)
                    {
                        var IDcompare = entry.SelectToken("drivers[0].playerID");

                        if (drivers[i].Item1 == IDcompare.ToString())
                        {
                            int gridposition = i + 1;

                            entrylistobject["entries"][playerIndex]["defaultGridPosition"] = gridposition;
                            string entrylist = Newtonsoft.Json.JsonConvert.SerializeObject(entrylistobject, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(@"cfg\entrylist.json", entrylist, Encoding.Unicode);
                        }
                    }
                }
                sessions.RemoveQualifying();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
