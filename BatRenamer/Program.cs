using System;
using System.Collections.Generic;
using System.IO;
using BatRenamer.Models.Entities;
using BatRenamer.Models.Services;
using BatRenamer.Models.Exceptions;
using BatRenamer.Models;

namespace BatRenamer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Iinitial variables
                List<NameInfo> list = new List<NameInfo>();

                Console.Write("Enter the folder where the files to be renamed are located: ");
                string path = @Console.ReadLine();
                string pathWithArchive = @path + @"\Renamer.bat";
                bool cont = true;
                Console.WriteLine($"\nEnter the original file names, then enter the name you want to rename, separated by a semicolon.EX: '{Messages.formatExample}'\n");
                do
                {
                    string c = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(c))
                    {
                        break;
                    }
                    if (!c.Contains(";") || !c.Contains("."))
                    {
                        throw new StringStructureException($"INVALID FORMAT! Format must be like: {Messages.formatExample}");
                    }


                    string[] fullString = c.Split(";");
                    list.Add(new NameInfo(fullString[0], fullString[1]));

                } while (cont);

                // BatBuilder constructor
                BatBuilder b = new BatBuilder(list);

                // Process to create, write, execute and delete the BAT file
                b.CreateAndWriteFile(pathWithArchive);
                Console.WriteLine("PROCESSING...");
                b.Execute(pathWithArchive, path);
                b.RemoveBat(pathWithArchive);
                Console.WriteLine("\nFile(s) renamed!");

                // Finish step
                Console.Write("Press any key to close.  ");
                Console.ReadLine();
            }
            catch (StringStructureException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
