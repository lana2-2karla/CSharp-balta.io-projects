namespace Calculator
{
    class Program
    {
        static void Main(string[] args) 
        {
            Divisao();
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
            }
        }

    }
    
}