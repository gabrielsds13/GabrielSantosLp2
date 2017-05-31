using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 600, L = 800;
            
            Objeto2D x = new Objeto2D();
            
            Console.Write(" Digitr X inicial:");
            x.x = int.Parse(Console.ReadLine());

            Console.Write(" Digitr Y inicial:");
            x.y  = int.Parse(Console.ReadLine());




            while (true)
            {
                Console.Write(" Digite comando: ");
                ConsoleKey comando = Console.ReadKey().Key;

                if (comando == ConsoleKey.RightArrow)
                {
                    x.AndarPD();
               
                }
                else if (comando == ConsoleKey.LeftArrow)
                {
                    x.AndarPE();
                }

                if (x.x > 0 && x.x < 800)
                    Console.WriteLine("{0},{1}", x.x,x.y);
                else
                {
                    Console.WriteLine("{0},{1}", x.x, x.y);

                    if

                }
            }
        
        
        
        
        
        
        
        }
    }
}
