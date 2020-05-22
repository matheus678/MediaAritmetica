using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá usuário, vou ajudá-lo a tirar a média aritmética de 3 números reais.");

            Console.WriteLine(" Pressione enter para continuar:");

            Console.ReadKey();



            Console.WriteLine("Digite o primeiro número:");

            double valor1 =  double.Parse (Console.ReadLine ());



            Console.WriteLine("Digite o segundo número:");

            double valor2 =  double.Parse (Console.ReadLine ());



            Console.WriteLine("Digite o terceiro número:");

            double valor3 =  double.Parse (Console.ReadLine ());



            Console.Write("Sua média é aritmetica:");

            double resultado1 = valor1 + valor2 + valor3;

            double resultado2 = resultado1 /3;

            Console.WriteLine(resultado2);

            Console.ReadKey();


        }
    }
}
