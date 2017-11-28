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
            string lõpetada = "Mdea";
            Console.WriteLine("Mida tahad teha? rename/kustuta/mõlemat");
            string vastus = Console.ReadLine();
            if (vastus == "rename")
            {
                while (lõpetada != "stop" || lõpetada != "stopp")
                {
                    Nimetamine.rename();
                    Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                    lõpetada = Console.ReadLine();
                }
            }
            else if (vastus == "kustuta")
            {
                while (lõpetada != "stop" || lõpetada != "stopp")
                {
                    kustuta.delete();
                    Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                    lõpetada = Console.ReadLine();
                }
            }
            else if (vastus == "mõlemat")
            {
                while (lõpetada != "stop" || lõpetada != "stopp")
                {
                    kustuta.delete();
                    Nimetamine.rename();
                    Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                    lõpetada = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Õpi juhendeid lugema");
            }
        }
    }
}
