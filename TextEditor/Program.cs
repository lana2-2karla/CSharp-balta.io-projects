﻿namespace TextEditor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("olaaa");
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            string? option = Console.ReadLine();

            if (!string.IsNullOrEmpty(option))
            {
                int optionNumber = int.Parse(option);

                switch (optionNumber)
                {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Create(); break;
                default: Menu(); break;
                }
            }

        }

        static void Open() 
        {
            
        }

        static void Create()
        {

        }
    }
}
