
using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while (true)
            {
                Console.Write("Faça sua pergunta: ");
                input = Console.ReadLine();

                if (input.ToUpper() == "EXIT")
                {
                    Console.WriteLine("A sair...");
                    break;
                }
                switch (input.ToLower())
                {
                    case "Como estás?":
                        Console.WriteLine("Estou bem, obrigado(a).");
                        break;

                    case "Qual é o teu nome?":
                        Console.WriteLine("Meu nome é Maria.");
                        break;

                    case "Como vai o teu dia?":
                        Console.WriteLine("O meu dia vai bem, obrigado(a).");
                        break;

                    case "O que vais fazer hoje?":
                        Console.WriteLine("Hoje vou estudar.");
                        break;

                    default:
                        Console.WriteLine("Não reconheci a sua pergunta.");
                        break;
                }
            }
        }
    }
}
