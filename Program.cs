using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje7
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
            bool Prim = true;
            int i, j;
            Console.WriteLine("Prosti brojevi od 1 do 100 su: ");
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        Prim = false;
                        break;
                    }
                }
                if (Prim)
                {
                    Console.Write("\t" + i);
                }
                Prim = true;
            }
            Console.ReadKey();

        }
            }
        }
    

