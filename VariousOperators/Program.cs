using System;

namespace VariousOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro não negativo: ");
            byte numero = Convert.ToByte(Console.ReadLine()); 

            Console.WriteLine(numero / 2);            
            Console.WriteLine(numero << 3);          
            Console.WriteLine(numero ^ 6);             
            Console.WriteLine(numero > 10);           
        }
    }
}

