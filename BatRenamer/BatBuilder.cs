using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatRenamer
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
    }
}
