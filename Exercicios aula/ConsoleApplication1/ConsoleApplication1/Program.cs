
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double NVeiculos, Km, potencia;
            string modelo, Carro, Classificaçao;

            Console.WriteLine("informe o numero de veiculos do galpao");
            NVeiculos = double.Parse(Console.ReadLine());


            for (int i = 0; i <= NVeiculos; i++)
            {

                Console.WriteLine("informe o modelo do veiculo {0}", i);
                modelo = (Console.ReadLine());

                Console.WriteLine("informe a quilometragem do veiculo {0}", i);
                Km = double.Parse(Console.ReadLine());

                Console.WriteLine("informe a potencia do veiculo {0}", i);
                potencia = double.Parse(Console.ReadLine());

                
                if (Km <= 5000)
                {
                    Carro = "novo";
                }
                else if (Km > 5000 && Km <= 30000)
                {
                    Carro = "seminovo";
                }
                else
                {
                    Carro = "velho";
                }

                if (potencia > 200)
                {
                    Classificaçao = "potente";
                }
                else if (potencia >= 120 && potencia <= 200)
                {
                    Classificaçao = "forte";
                }
                else
                {
                    Classificaçao = "popular";
                }


                Console.WriteLine(" o carro {0} e classificado como {1} e {2},", modelo, Carro, Classificaçao);
                Console.ReadKey();

              

            }
        
        
        
        }
         
        public static string Classif(string modelo; double Km; double potencia)
        {
                
               
    
        
    
         
        }
    
    
    
    }
}            
    
        
        

  

