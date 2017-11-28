using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TelesarjadeRenameimine
{
    class ChangeDirectory
    {
        public void folder()
        {
            Console.WriteLine(@"Mis on path, kus on folderid millest failid välja tuua? (See peab lõppema folderiga, näiteks E:\TestFolder)");
            string path = Console.ReadLine() + @"\";
            if (path == @"\")
            {
                Console.WriteLine("---Lõpetan liigutamise---");
                return;
            }
            string[] AllFolders = Directory.GetDirectories(path);
            foreach (string folder in AllFolders)
            {
                string[] AllFiles = Directory.GetFiles(folder);
                foreach (string file in AllFiles)
                {
                    if (File.Exists(path + Path.GetFileName(file)))
                    {
                        Console.WriteLine(path + Path.GetFileName(file) + " juba eksisteerib");
                    }
                    else
                    {
                        File.Move(file, path + Path.GetFileName(file));
                    }
                }
            }
            Console.WriteLine("Kõik on folderitest välja toodud!");
            Console.WriteLine();
            Console.WriteLine("Kustutada kõik folderid? (y/n)");
            string vastus = Console.ReadLine();
            if (vastus == "kustutada" || vastus == "y")
            {
                foreach (string folder in AllFolders)
                {
                    Directory.Delete(folder, true);
                }
                Console.WriteLine("Kustutatud!");
            }
        }
    }
}
