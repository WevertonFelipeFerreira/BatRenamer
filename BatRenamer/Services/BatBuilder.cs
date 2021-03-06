using System.Collections.Generic;
using System.Text;
using System.IO;
using BatRenamer.Entities;

namespace BatRenamer.Services
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

        private string getBatText() 
        {
            return batText().ToString();
        }

        public void CreateAndWriteFile(string path)
        {
            try
            {
                string content = getBatText();
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(content);
                }
            }
            catch (IOException e) 
            {
                throw new IOException("Folder not found!");
            }
        }

        public void Execute(string pathWithArchive,string pathBase) 
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = pathWithArchive;
            proc.StartInfo.WorkingDirectory = pathBase;
            proc.Start();
        }

        public void RemoveBat(string path) 
        {
            File.Delete(path);
        }
    }
}
