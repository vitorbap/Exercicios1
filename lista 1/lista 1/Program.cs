using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1

            /*int N1, N2, N3;

            //Solicitando entrada do usuário
            Console.WriteLine("Digite o primeiro numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            N3 = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------");
            //Exibir resultado
            Console.WriteLine("Resultado: ");

            //Laços Condicionais
            if (N1 < N2 & N1 < N3)
            {
                Console.WriteLine($"O primeiro numero é o MENOR {N1} ");
            }
            else if (N2 < N1 & N2 < N3)
            {
                Console.WriteLine($"O segundo numero é o MENOR {N2}");
            }
            else if (N3 < N1 & N3 < N2)
            {
                Console.WriteLine($"O terceiro numero é o MENOR {N3}");
            }
            else if (N1 == N2 & N2 == N3 & N3 == N1)
            {
                Console.WriteLine("Todos os numeros são iguais!");
            }
            else
            {
                Console.WriteLine("A operação falhou! Tenta novamente.");
            }

            Console.ReadLine();
            */

            //EXERCICIO 2

            /*int N1, N2, N3;

            Console.WriteLine("Digite o primeiro numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            N3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: ");

            if (N1 > N2 & N1 > N3)
            {
                Console.WriteLine($"O numero MAIOR é {N1} ");
            }
            else if (N2 > N1 & N2 > N3)
            {
                Console.WriteLine($"O numero MAIOR é {N2}");
            }
            else if (N3 > N2 & N3 > N1)
            {
                Console.WriteLine($"O numero MAIOR é {N3}");
            }
            else if (N1 == N2 & N2 == N3)
            {
                Console.WriteLine("Os numero são iguais!");
            }
            else
            {
                Console.WriteLine("Falha tente novamente!");
            }

            Console.ReadLine();*/

            //EXERCICIO 3

            int urgencia;

            Console.WriteLine("Descreva a sua solicitação: ");
            Console.ReadLine();
            Console.WriteLine("Em uma escala de 1 a 10 digite o nivel de urgencia para esse chamado");
            urgencia = int.Parse(Console.ReadLine());

            if (urgencia <= 3)
            {
                Console.WriteLine("O nivel de urgência é BAIXO");
            }
            else if (urgencia > 3 & urgencia <= 6)
            {
                Console.WriteLine("O nivel de urgência é MÉDIO");
            }
            else if (urgencia > 6 & urgencia <= 9)
            {
                Console.WriteLine("O nivel de urgência é ALTO");
            }
            else
            {
                Console.WriteLine("O nivel de urgência é GRAVE");
            }

            Console.ReadLine();
        }
    }
}
