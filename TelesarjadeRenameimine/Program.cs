using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//TODO
//* Kustutada ühte tüüpi failid(Kuradi subtiitlid ja tekst failid) [TEHTUD]
//* Ainult renameida ühte faili tüüpi(mp4, mkv või mis iganes user sisestab)
//* Folderitest kõik asjad välja tuua

namespace TelesarjadeRenameimine
{
    class Program
    {
        static void Main(string[] args)
        {
            TaasNimetamine Nimetamine = new TaasNimetamine();
            Kustutamine kustuta = new Kustutamine();
            string vastus = "Mdea";
            string lõpetada = "mdea";

            while (vastus != "exit" || vastus != "stop")
            {
                lõpetada = "Mitte stop";
                Console.WriteLine("Mida tahad teha?");
                Console.WriteLine("* rename");
                Console.WriteLine("* kustuta");
                Console.WriteLine("* mõlemat");
                Console.WriteLine("* exit");
                vastus = Console.ReadLine();
                Console.WriteLine();

                if (vastus == "rename")
                {
                    while (lõpetada != "stop")
                    {
                        Nimetamine.rename();
                        Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                        lõpetada = Console.ReadLine();
                    }
                }
                else if (vastus == "kustuta")
                {
                    while (lõpetada != "stop")
                    {
                        kustuta.delete();
                        Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                        lõpetada = Console.ReadLine();
                    }
                }
                else if (vastus == "mõlemat" || vastus == "molemat")
                {
                    while (lõpetada != "stop")
                    {
                        kustuta.delete();
                        Nimetamine.rename();
                        Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                        lõpetada = Console.ReadLine();
                    }
                }
                else if (vastus == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fuck off");
                }
                Console.WriteLine();
            }
        }
    }
}
