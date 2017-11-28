using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//TODO
//* Kustutada ühte tüüpi failid(Kuradi subtiitlid ja tekst failid) [TEHTUD]
//* Ainult renameida ühte faili tüüpi(mp4, mkv või mis iganes user sisestab) [TEHTUD]
//* Folderitest kõik asjad välja tuua [TEHTUD]

namespace TelesarjadeRenameimine
{
    class Program
    {
        static void Main(string[] args)
        {
            TaasNimetamine Nimetamine = new TaasNimetamine();
            Kustutamine kustuta = new Kustutamine();
            ChangeDirectory open = new ChangeDirectory();

            string vastus = "Mdea";
            string lõpetada = "mdea";

            while (vastus != "exit" || vastus != "stop")
            {
                lõpetada = "Mitte stop";
                Console.WriteLine("Mida tahad teha?");
                Console.WriteLine("* rename");
                Console.WriteLine("* delete");
                Console.WriteLine("* both (delete siis rename)");
                Console.WriteLine("* move");
                Console.WriteLine("* exit");

                vastus = Console.ReadLine();
                Console.WriteLine();

                if (vastus == "rename" || vastus == "r")
                {
                    while (lõpetada != "stop")
                    {
                        Nimetamine.rename();
                        Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                        lõpetada = Console.ReadLine();
                    }
                }
                else if (vastus == "kustuta" || vastus == "delete" || vastus == "d")
                {
                    while (lõpetada != "stop")
                    {
                        kustuta.delete();
                        Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                        lõpetada = Console.ReadLine();
                    }
                }
                else if (vastus == "mõlemat" || vastus == "molemat" || vastus == "both" || vastus == "b")
                {
                    while (lõpetada != "stop")
                    {
                        kustuta.delete();
                        Nimetamine.rename();
                        Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                        lõpetada = Console.ReadLine();
                    }
                }
                else if (vastus == "move" || vastus == "liiguta" || vasuts == "m")
                {
                    while (lõpetada != "stop")
                    {
                        open.folder();
                        Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                        lõpetada = Console.ReadLine();
                    }
                }
                else if (vastus == "exit" || vastus == "e")
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
