using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TelesarjadeRenameimine
{
    class TaasNimetamine
    {
        public void rename()
        {
            Console.WriteLine(@"Mis on path, kus failid on? (See peab lõppema folderiga, näiteks E:\TestFolder)");
            string path = Console.ReadLine() + @"\";
            string[] AllFiles = Directory.GetFiles(path);
            Console.WriteLine("Mis tahad, et faili nimi oleks? (Näide: S01E*, tärni osa küsin hiljem)");
            string nimi = Console.ReadLine();
            Console.WriteLine("Mis osast/episoodist alustada? (See tärn)");
            int EsimeneOsa = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mis tüüpi failid need on? (.mp4, .avi, .wma jne)");
            string failiTüüp = Console.ReadLine();

            foreach (string file in AllFiles)
            {
                //Siin on if, sest kui sisestad S01E*, siis see näeb välja S01E1 kuni S01E10, kuid nii on see S01E01 kuni S01E10 (palju ilusam)
                if (EsimeneOsa < 10)
                {
                    File.Move(file, path + nimi + "0" + EsimeneOsa + failiTüüp);
                }
                else
                {
                    File.Move(file, path + nimi + EsimeneOsa + failiTüüp);
                }
                EsimeneOsa++;
            }
        }
    }
}
