using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma1 = Somar(10,20,30);
            Console.WriteLine(soma1);
            Console.ReadLine();
        }
        static void GerarPreco(int preco)
        {
            int valorFinal = preco + (2 * preco);
            Console.WriteLine("Valor final: " + valorFinal);
        }
        static void TsxtoNome()
        {
            Console.WriteLine("Hello world\n");
            Console.WriteLine("Meu nome é Diego Vieira");
            string nome = "";
            Console.WriteLine("Qual o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é " + nome);
            Console.ReadLine();
        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }

    }
}
