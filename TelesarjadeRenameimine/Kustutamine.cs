using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TelesarjadeRenameimine
{
    class Kustutamine
    {
        public void delete()
        {
            Console.WriteLine(@"Mis on path, kus failid on? (See peab lõppema folderiga, näiteks E:\TestFolder)");
            string path = Console.ReadLine() + @"\";
            Console.WriteLine("Mis faili tüüpi kustutada? (.srt, .txt, .jpeg)");
            string failitüüp = Console.ReadLine();
            string[] AllFiles = Directory.GetFiles(path, "*" + failitüüp);

            foreach (string file in AllFiles)
            {
                File.Delete(file);
            }
        }
    }
}
