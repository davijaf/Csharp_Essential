using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        public static string title = "Treinamento Essencial C#";
        public static int whichPart;
        static void Main(string[] args)
        {
            whichPart = 2;
            var message = string.Format("Welcome to {0} Part {1}", title, whichPart);
            Console.WriteLine(message);
            Console.WriteLine("Pressione a tecla Enter para sair.");
            Console.ReadLine();
        }
    }
}