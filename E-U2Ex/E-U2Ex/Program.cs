using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_U2Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Agencia de Autos";
            Auto menu = new Auto();
            menu.Menu();
        }
    }
}
