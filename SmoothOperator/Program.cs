using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro: ");
            string numero = Console.ReadLine();
            sbyte n = sbyte.Parse(numero);
            n--;
            Console.WriteLine(n);
            sbyte numeroInt = ++n;
            Console.WriteLine(numeroInt);
        }
    }
}
