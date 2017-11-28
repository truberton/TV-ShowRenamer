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
            if (path == @"\")
            {
                Console.WriteLine("---Lõpetan taasnimetamise---");
                return;
            }
            Console.WriteLine("Mis tüüpi failid need on? (.mp4, .avi, .wma jne)");
            string failiTüüp = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(failiTüüp))
            {
                Console.WriteLine("---Lõpetan taasnimetamise---");
                return;
            }
            string[] AllFiles = Directory.GetFiles(path, "*" + failiTüüp);
            Console.WriteLine("Mis tahad, et faili nimi oleks? (Näide: S01E*, tärni osa küsin hiljem)");
            string nimi = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nimi))
            {
                Console.WriteLine("---Lõpetan taasnimetamise---");
                return;
            }
            Console.WriteLine("Mis osast/episoodist alustada? (See tärn)");
            int EsimeneOsa = Int32.Parse(Console.ReadLine());
            if (string.IsNullOrEmpty(EsimeneOsa.ToString()))
            {
                Console.WriteLine("---Lõpetan taasnimetamise---");
                return;
            }

            foreach (string file in AllFiles)
            {
                //Siin on if, sest kui sisestad S01E*, siis see näeb välja S01E1 kuni S01E10, kuid nii on see S01E01 kuni S01E10 (palju ilusam)
                if (EsimeneOsa < 10)
                {
                    if (File.Exists(path + nimi + "0" + EsimeneOsa + failiTüüp))
                    {
                        Console.WriteLine(path + nimi + "0" + EsimeneOsa + failiTüüp + " juba eksisteerib, jääb vahele");
                    }
                    else
                    {
                        File.Move(file, path + nimi + "0" + EsimeneOsa + failiTüüp);
                    }
                }
                else
                {
                    if (File.Exists(path + nimi + EsimeneOsa + failiTüüp))
                    {
                        Console.WriteLine(path + nimi + EsimeneOsa + failiTüüp + " juba eksisteerib, jääb vahele");
                    }
                    else
                    {
                        File.Move(file, path + nimi + EsimeneOsa + failiTüüp);
                    }
                }
                EsimeneOsa++;
            }
        }
    }
}
