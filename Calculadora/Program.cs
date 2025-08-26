using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração, Multiplicação, Divisão, Raiz, Potência, Sair };

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a CALCULADORA");
            bool EscolheuSair = false;
            while (!EscolheuSair) // ENQUANTO O USUARIO NÃO(!) ESCOLHER SAIR EXIBA O MENU
            {
                Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Raiz\n6-Potência\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                Console.WriteLine(opcao);

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtração:
                        Subtraçao();
                        break;
                    case Menu.Multiplicação:
                        Multiplicação();
                        break;
                    case Menu.Divisão:
                        Div();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Potência:
                        Pot();
                        break;
                    case Menu.Sair:
                        EscolheuSair = true;
                        break;
                }

                Console.Clear();
            }
            Console.WriteLine("Você resolveu sair do programa. Volte sempre!");
        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois Numeros. ");
            Console.WriteLine("Digite o Primeiro Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O Resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
        static void Subtraçao()
        {
            Console.WriteLine("Subtração de dois Numeros.");
            Console.WriteLine("Digite um Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro Numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O Resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
        static void Multiplicação()
        {
            Console.WriteLine("Mulitiplicação de dois Numeros.");
            Console.WriteLine("Digite um Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro Numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O Resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois Numeros.");
            Console.WriteLine("Digite um Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro Numero:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O Resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de um Numero.");
            Console.WriteLine("Digite a base: ");
            int BaseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Expoente:");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(BaseNum, expo);
            Console.WriteLine($"O Resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um Numero: ");
            Console.WriteLine("Digite a base: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O Resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
    }
}
