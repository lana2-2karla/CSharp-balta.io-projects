namespace TextEditor
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("");
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
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
            Console.WriteLine("-------------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Insert);

            Console.Write(text);
            
        }
    }
}
