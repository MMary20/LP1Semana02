using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira número inteiro: ");
        
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            sbyte n = (sbyte)numero;
            
            Console.WriteLine(n - 1);  
            Console.WriteLine(n + 1);  
        }
    }
}
