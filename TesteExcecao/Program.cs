using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();

                Console.ReadLine();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Aconteceu um erro.");
            }
        }

        //Teste com a cadeia de chama:
        // Metodo -> TestaDivisao -> Dividir

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);

                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possível dividir por zero.");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
            //TESTESTETSET
        }
    }
}
    

