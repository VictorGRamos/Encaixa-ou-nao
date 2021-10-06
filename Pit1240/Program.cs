using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pit1240
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            string a, b;
            qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                string[] v;
                v = Console.ReadLine().Split(' ');
                a = v[0];
                b = v[1];
                if (a.EndsWith(b))
                {
                    Console.WriteLine("encaixa");
                }
                else {
                    Console.WriteLine("nao encaixa");
                }
            }
        }
    }
}
