using System;

namespace GettingInput 
{
    class Program { 
        static void Main()
        {
            Console.WriteLine("Quantos anos você tem?:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantos anos tem seu amigo(a)?:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine($"A soma das suas idades é: {soma}");
        }
    }
}