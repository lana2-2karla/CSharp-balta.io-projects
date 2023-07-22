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

            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
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
            Thread.Sleep(2500);
        }
    }
}