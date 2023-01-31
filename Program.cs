using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            double c = -274, f, k;
            Console.WriteLine("--- Conversor de temperaturas ---");

            Valor:         
            Console.WriteLine("Digite a temperatura em Celsius:");            
            c = Convert.ToDouble(Console.ReadLine());
                               
            if(c >= -273)
            {
            Escolha:
                Console.WriteLine("Para qual unidade de medida quer converter?");
                Console.WriteLine("Digite f para fahrenheit ou k para kelvin");
                int selecao = Console.Read();                
                Thread.Sleep(1000);

                if (selecao == 'f')
                {
                    //conversor para fahrenheit
                    if (c == 0)
                    {
                        f = 32;
                    }
                    else
                    {
                        f = (c * 1.8) + 32;
                    }
                    Console.WriteLine("O valor {0} em celsius convertido para fahrenheit é igual a {1}", c, f);
                    Thread.Sleep(2000);
                    selecao = 0;
                }
                else if (selecao == 'k')
                {

                    //conversor para kelvin
                    k = c + 273;
                    Console.WriteLine("O valor {0} em celsius convertido para kelvin é igual a {1}", c, k);
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Não foi possível identificar o tipo especificado, tente novamente");
                    Clear();
                    Thread.Sleep(2000);
                    goto Escolha;                    
                }

                Clear();
                Console.WriteLine("Conversão concluída com sucesso, deseja converter outro valor?");
                Console.WriteLine("Digite sim para sim ou digite qualquer outro valor para não");                
                string input = Console.ReadLine();
                
                if (input == "sim")
                {
                    goto Valor;
                } else
                {
                    goto Fim;
                }
                                               
            } else
            {
                Console.WriteLine("Não foi possível converter o valor especificado pois está abaixo do zero absoluto, tente outro valor");
                Thread.Sleep(500);
                goto Valor;
            }

            Fim:
            Console.WriteLine("O programa terminou corretamente e apresentou 0 erros");
            Console.WriteLine("Digite qualquer tecla para sair");
            Console.ReadKey();
            
        }

        static void Clear()
        {
            //clear
            Console.Write("");
            Console.Read();
            Console.Write("");
            Console.Read();            
            return;
        }
    }
}
