using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 2; n <= 20; n++)
            {
                if (czy_pierwsza(n))
                {
                    Console.WriteLine("Liczba: "+n+" jest pierwsza");
                    Console.ReadKey();
                }
                else
                Console.WriteLine("Liczba: "+n+" nie jest pierwsza");
                Console.ReadKey();
            }
            bool czy_pierwsza(int n)
            {
                
                if (n < 2)
                {
                    Console.WriteLine("gdy liczba jest mniejsza niż 2 to nie jest pierwszą");
                    Console.ReadKey();
                    return false;
                }
                for (int i = 2;  i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("gdy znajdziemy dzielnik, to dana liczba nie jest pierwsza");
                        Console.ReadKey();
                        return false;
                    }
                }
                return true;
            }

        }
           
        
    }
    
}
