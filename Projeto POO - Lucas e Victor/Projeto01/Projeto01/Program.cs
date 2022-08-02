using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome da pessoa: "); string n = Console.ReadLine();
            Console.Write("Digite a idade de {0}: ", n); int i  = int.Parse(Console.ReadLine());

            p.Nome = "Thiagão da Massa";

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
