namespace StopWatch
{
    class Program
    {
        static void Main()
        {
           Menu();
        }

        static void Menu() {

            Console.Clear();

            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string? data = Console.ReadLine();

            if (data == "0")
                System.Environment.Exit(0);

            if (!String.IsNullOrEmpty(data))
            {
                data = data.ToLower();
                // Substring --> Pega a quantidade de caracteres da posição informada
                char type = char.Parse(data.Substring(data.Length -1, 1));
                int time = int.Parse(data.Substring(0, data.Length -1));

                int multiplier = 1;

                if (type == 'm')
                    multiplier = 60;

                Start(time * multiplier);
                
            }
                
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                //Thread = execução atual --> Estamos pedindo para a execução "dormir" por 1 segundo
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }
}