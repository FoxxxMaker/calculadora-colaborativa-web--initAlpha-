using System;

namespace CalculadoraWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Colaborativa Web");
            System.Console.WriteLine("Escolha o calculo que deseja: ");

            int escolha = int.Parse(Console.ReadLine());

           
        }

        // Integrante 1
        public static double Adicao(double a, double b)
        {
            return a + b;
        }

        // Integrante 2
        // public static double Subtracao(double a, double b)
        // {
        //     // Implementar aqui 
        // }

        
        public static double Multiplicacao(double a, double b)
        {
             return a * b;
        }

        // Integrante 4
         public static double Divisao(double a, double b)
         {  
              return a/b;
        }


  
        public static double Potenciacao(double a, double b)
        {
            System.Console.WriteLine("insira a base:");

            b = Console.ReadLine();

            System.Console.WriteLine("insira a potência: ");

            a = Console.ReadLine();

            for(b; b < a; b++)
            {
                int calc;

                calc += a * a;
            }

            System.Console.WriteLine($"O resultado é: " calc );
        }
    }
}

