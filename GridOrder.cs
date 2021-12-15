using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ACC_Reverse_Grid_App
{
    class GridOrder
    {
        FileReader fileReader = new FileReader();
        int dnf = 0;

        public void GetDriversFromLastRace(string path)
        {
            try
            {
                var drivers = DriversToListFromResults(path);

                Entrylist entrylist = new Entrylist();
                entrylist.SetGrid(drivers);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        public List<Tuple<string, string>> DriversToListFromResults(string path)
        {
            //get result file
            var outputJObject = fileReader.Readfile(path);
            var results = outputJObject["sessionResult"];
            var leaderboard = results["leaderBoardLines"];
            var drivers = new List<Tuple<string, string>>();

            foreach (JObject leaderboardItem in leaderboard)
            {
                //Sometimes the game doesn't put lapcount 0 to dnf drivers, so it has to be calculated from the totaltime as well
                if (Settings.Instance.UseDnfSettings)
                {
                    if (Convert.ToInt32(leaderboardItem["timing"]["lapCount"]) == 0 || Convert.ToInt32(leaderboardItem["timing"]["totalTime"]) < Settings.Instance.LowDNF || Convert.ToInt32(leaderboardItem["timing"]["totalTime"]) > Settings.Instance.HighDNF)
                    {
                        //how many dnfs
                        dnf = dnf + 1;
                    }
                }
                
                string id = leaderboardItem["currentDriver"]["playerId"].ToString();
                string firstName = leaderboardItem["currentDriver"]["firstName"].ToString();
                string lastName = leaderboardItem["currentDriver"]["lastName"].ToString();
                string fullName = firstName + " " + lastName;
                drivers.Add(new Tuple<string, string>(id, fullName));
            }

            return drivers;
        }

        public List<Tuple<string, string>> reverseWithDnfCount(List<Tuple<string, string>> drivers, int dnf)
        {
            var reversedDrivers = new List<Tuple<string, string>>();
            int reverselength = 0;
            if (Settings.Instance.DNFsBackOfGrid == true)
            {
                //dnfs start last
                reverselength = drivers.Count() - dnf;
            }
            
            for (int i = drivers.Count() - 1; i == drivers.Count() - reverselength; i++)
            {
                reversedDrivers.Add(drivers[i]);
            }

            return reversedDrivers;
        }
    }
}
