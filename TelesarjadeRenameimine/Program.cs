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
            TaasNimetamine Nimetamine = new TaasNimetamine();
            string lõpetada = "Mdea";

            while (lõpetada != "stop" || lõpetada != "stopp")
            {
                Nimetamine.rename();
                Console.WriteLine("Kui tahad lõpetada kirjuta stop, muidu kirjuta mis iganes muud");
                lõpetada = Console.ReadLine();
            }
        }
    }
}
