using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OitoPontoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp, resp2;
            Console.WriteLine("Deseja comprar algum item?");
            resp = Console.ReadLine();
            if (resp == "Não")
            {
                Console.WriteLine("Operação finalizada.");

            }
            else
            {
                do
                {
                    Console.WriteLine("Deseja comprar mais alguma coisa?");
                    resp2 = Console.ReadLine();

                } while (resp2 == "Sim");
            }
        }
    }
}