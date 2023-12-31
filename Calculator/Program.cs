﻿namespace Calculator
{
    class Program
    {
        static void Main(string[] args) 
        {
            Menu();
        }
    
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");

            Console.WriteLine("1 - Soma;");
            Console.WriteLine("2 - Subtração;");
            Console.WriteLine("3 - Divisão;");
            Console.WriteLine("4 - Multiplicação;");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção: ");

            string? option = Console.ReadLine();

            switch (option)
            {
                case "1": Soma(); break;
                case "2": Subtracao(); break;
                case "3": Divisao(); break;
                case "4": Multiplicacao(); break;
                case "5": Sair(); break;
                default: Menu(); break;
            }
        }

        static void Soma() 
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            string? oneValue = Console.ReadLine();

            Console.WriteLine("Segundo valor: ");
            string? secondValue = Console.ReadLine();

            Console.WriteLine("");
             
            // retorna true se o valor for nulo ou uma string vazia
            if (!string.IsNullOrWhiteSpace(oneValue) && !string.IsNullOrWhiteSpace(secondValue))
            {
                float OneValueNumber = float.Parse(oneValue);
                float SecondValueNumber = float.Parse(secondValue);
               
                float Summation = OneValueNumber + SecondValueNumber;

                Console.WriteLine($"O resultado da soma é: {Summation}");
                Console.ReadKey();
                Menu();
            }
        }
    
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            string? oneValue = Console.ReadLine();

            Console.WriteLine("Segundo valor: ");
            string? secondValue = Console.ReadLine();

            Console.WriteLine("");
             
            // retorna true se o valor for nulo ou uma string vazia
            if (!string.IsNullOrWhiteSpace(oneValue) && !string.IsNullOrWhiteSpace(secondValue))
            {
                float OneValueNumber = float.Parse(oneValue);
                float SecondValueNumber = float.Parse(secondValue);
               
                float subtraction = OneValueNumber - SecondValueNumber;

                Console.WriteLine($"O resultado da subtração é: {subtraction}");
                Console.ReadKey();
                Menu();
            }
        }
    
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            string? oneValue = Console.ReadLine();

            Console.WriteLine("Segundo valor: ");
            string? secondValue = Console.ReadLine();

            Console.WriteLine("");
             
            // retorna true se o valor for nulo ou uma string vazia
            if (!string.IsNullOrWhiteSpace(oneValue) && !string.IsNullOrWhiteSpace(secondValue))
            {
                float OneValueNumber = float.Parse(oneValue);
                float SecondValueNumber = float.Parse(secondValue);
               
                float division = OneValueNumber / SecondValueNumber;

                Console.WriteLine($"O resultado da divisão é: {division}");
                Console.ReadKey();
                Menu();
            }
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            string? oneValue = Console.ReadLine();

            Console.WriteLine("Segundo valor: ");
            string? secondValue = Console.ReadLine();

            Console.WriteLine("");
             
            // retorna true se o valor for nulo ou uma string vazia
            if (!string.IsNullOrWhiteSpace(oneValue) && !string.IsNullOrWhiteSpace(secondValue))
            {
                float OneValueNumber = float.Parse(oneValue);
                float SecondValueNumber = float.Parse(secondValue);
               
                float multiplication = OneValueNumber * SecondValueNumber;

                Console.WriteLine($"O resultado da multiplicação é: {multiplication}");
                Console.ReadKey();
                Menu();
            }
        }
    
        static void Sair() 
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar nosso sistema, até breve!!");
            System.Environment.Exit(0);
        }

    }
    
}