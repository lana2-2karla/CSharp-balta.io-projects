namespace StopWatch
{
    class Program
    {
        static void Main()
        {
           Start();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                //Thread = execução atual --> Estamos pedindo para a execução "dormir" por 1 segundo
                Thread.Sleep(1000);
            }
        }
    }
}