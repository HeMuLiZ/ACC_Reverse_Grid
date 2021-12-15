using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACC_Reverse_Grid_App
{
    class Sessions
    {
        FileReader filereader = new FileReader();
        Server server = new Server();
        public void RemoveQualifying()
        {
            string path = Directory.GetCurrentDirectory() + @"\cfg\event.json";

            var eventObject = filereader.Readfile(path);

            var sessions = eventObject.SelectToken("$.sessions");

            //if 3 sessions (practice, qualifying, race)
            if (sessions.Count() == 3)
            {
                //save sessions
                File.WriteAllText("savedEvent.json", eventObject.ToString(), Encoding.Unicode);

                //remove qualifying
                eventObject.SelectToken("$.sessions[1]").Remove();
                //change practice length
                var practiceMinutes = eventObject.SelectToken("$.sessions[0]").SelectToken("$.sessionDurationMinutes");
                Console.WriteLine(practiceMinutes);
                practiceMinutes.Replace(Settings.Instance.PracticeMinutes);

                File.WriteAllText(@"cfg\event.json", eventObject.ToString(), Encoding.Unicode);
            }
        }

        public void AddQualifying()
        {
            string path = Directory.GetCurrentDirectory() + @"\savedEvent.json";
            var eventObject = filereader.Readfile(path);

            File.WriteAllText(@"cfg\event.json", eventObject.ToString(), Encoding.Unicode);
        }
    }
}
