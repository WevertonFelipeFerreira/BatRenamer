using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BatRenamer.Entities
{
    public class BatBuilder
    {
       private readonly string baseString = "@echo off";
       private List<NameInfo> infosList { get; set; }

        public BatBuilder(List<NameInfo> infosList)
        {
            this.infosList = infosList;
        }

        private StringBuilder batText() 
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(baseString);
            foreach (var item in infosList)
            {
                s.AppendLine(item.GetLine());
            }
            return s;
        }

        public string getBatText() 
        {
            return batText().ToString();
        }

        public void CreateAndWriteFile(string path)
        {
            string content = getBatText();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write(content);
            }
        }
    //    public void Execute(string path) 
    //    {
    //        string[] path2 = Directory.GetDirectories(path);
    //        System.Diagnostics.Process.Start(@"C:\\Users\weverton.ferreira\Desktop\Nova pasta\Renamer.bat");
    //    }
    }
}
