using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TelesarjadeRenameimine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Mis on path, kus failid on? (See peab lõppema [\], näiteks E:\TestFolder\)");
            string path = Console.ReadLine();
            string[] AllFiles = Directory.GetFiles(path);
            Console.WriteLine("Mis tahad, et faili nimi oleks? (Näide: S01E*, tärni osa küsin hiljem)");
            string nimi = Console.ReadLine();
            Console.WriteLine("Mis osast/episoodist alustada? (See tärn)");
            int EsimeneOsa = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mis tüüpi failid need on? (.mp4, .avi, .wma jne)");
            string failiTüüp = Console.ReadLine();

            foreach (string file in AllFiles)
            {
                if (EsimeneOsa < 10)
                {
                    File.Move(file, path + nimi+ "0" + EsimeneOsa + failiTüüp);
                }
                else
                {
                    File.Move(file, path + nimi + EsimeneOsa + failiTüüp);
                }
                EsimeneOsa++;
            }
            Console.WriteLine(path + nimi + EsimeneOsa);
        }
    }
}
