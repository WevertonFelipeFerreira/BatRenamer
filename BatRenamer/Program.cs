using System;
using System.Collections.Generic;

namespace BatRenamer
{
    class Program
    {
        static void Main(string[] args)
        {
            string formatExample = "OriginalName.jpg;Renamed.jpg";
            List<NameInfo> list = new List<NameInfo>();

            bool cont = true;
            Console.WriteLine($"\nEnter the original filename, then enter the name you want to rename, separated by a semicolon.EX: '{formatExample}'");
            do
            {
                string c = Console.ReadLine();
                if (string.IsNullOrEmpty(c) || !c.Contains(";") || !c.Contains("."))
                {
                    Console.WriteLine($"INVALID FORMAT! Format must be like: {formatExample}");
                    break;
                }

                string[] fullString = c.Split(";");
                list.Add(new NameInfo(fullString[0], fullString[1]));

            } while (cont);

        }
    }
}
