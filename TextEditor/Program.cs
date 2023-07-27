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
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string? path = Console.ReadLine();

            if (!string.IsNullOrEmpty(path))
            {
                // esse using abre e fecha a execuxão de qualquer coisa automaticamente
                using (var file = new StreamReader(path)) {
                    string text = file.ReadToEnd();
                    Console.Clear();
                    Console.WriteLine(text);
                }

                Console.WriteLine("");
                Console.ReadLine();
                Menu();
            }
        }

        static void Create()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
            Console.WriteLine("-------------------");

            string text = "";

            // faça.. enquanto..
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Insert);

            Save(text);
            
        }
    
        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");

            var path = Console.ReadLine();


            if (!string.IsNullOrEmpty(path))
            {
                // esse using abre e fecha a execuxão de qualquer coisa automaticamente
                using (var file = new StreamWriter(path)) {
                    file.Write(text);
                }

                Console.WriteLine($"Arquivo {path} salvo com sucesso");
                Console.ReadLine();
                Menu();
            }

        }
   
    }
}
