using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ACC_Reverse_Grid_App
{
    class Server
    {
        public void RestartServer()
        {
            try
            {
                string serverPath = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "/settings.txt");
                var serverName = System.IO.Path.GetFileName(serverPath);
                serverName = serverName.Remove(serverName.Length - 4);

                var serverprocess = Process.GetProcesses().
                Where(pr => pr.ProcessName == serverName);

                foreach (var process in serverprocess)
                {
                    process.Kill();
                }
                Thread.Sleep(1000);
                Process.Start(serverName);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
    }
}
