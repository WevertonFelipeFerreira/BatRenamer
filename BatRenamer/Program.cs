using System;
using System.Collections.Generic;
using System.IO;
using BatRenamer.Entities;

namespace BatRenamer
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Diagnostics.Process.Start("c:\\batchfilename.bat");
            List<NameInfo> list = new List<NameInfo>();
            string formatExample = "OriginalName.jpg;Renamed.jpg";

            Console.Write("Enter the folder where the files to be renamed are located: ");
            string path = @Console.ReadLine()+@"\Renamer.bat";
            bool cont = true;
            Console.WriteLine($"\nEnter the original filename, then enter the name you want to rename, separated by a semicolon.EX: '{formatExample}'\n");
            do
            {
                string c = Console.ReadLine();
                if (string.IsNullOrEmpty(c)) 
                {
                    break;
                }
                if (!c.Contains(";") || !c.Contains("."))
                {
                    Console.WriteLine($"INVALID FORMAT! Format must be like: {formatExample}");
                    break;
                }

                string[] fullString = c.Split(";");
                list.Add(new NameInfo(fullString[0], fullString[1]));

            } while (cont);

            BatBuilder b = new BatBuilder(list);
            b.CreateAndWriteFile(path);
            System.Diagnostics.Process.Start(path);
            Console.WriteLine("\nFile(s) renamed!");

            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }
    }
}
