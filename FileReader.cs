using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ACC_Reverse_Grid_App
{
    class FileReader
    {
        JObject outputJobject;
        string output = "";
        string path = "";
        int everysecond = 0;
        public bool watcherSwitch { get; set; }

        //Catch result files when game create them
        public void Filewatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            string resultsfilespath = Directory.GetCurrentDirectory() + @"\results";
            watcher.Path = resultsfilespath;
            // Watch lastest file
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
             | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only race files
            watcher.Filter = "*R.json";
            //event handler
            watcher.Created += new FileSystemEventHandler(OnCreated);
            // Begin watching.
            watcherSwitch = true;
            watcher.EnableRaisingEvents = watcherSwitch;
        }

        public void OnCreated(object sender, FileSystemEventArgs createdFile)
        {
            GridOrder reverseGrid = new GridOrder();
            Qualifying quali = new Qualifying();
            string value = createdFile.FullPath;
            path = createdFile.FullPath;
            everysecond = everysecond + 1;

            if (everysecond == 1)
            {
                reverseGrid.GetDriversFromLastRace(path);
            }

            if(everysecond == 2)
            {
                everysecond = 0;
                quali.RemoveDefauldGridPositions();
            } 
        }

        public JObject Readfile(string path)
        {
            Console.WriteLine(path);
            using (var streamReader = new StreamReader(path, Encoding.Unicode))
            {
                output = streamReader.ReadToEnd();
                outputJobject = Newtonsoft.Json.JsonConvert.DeserializeObject(output) as JObject;
                return outputJobject;
            }
        }
    }
}
