namespace Calculator
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            string? OneValue = Console.ReadLine();

            Console.WriteLine("Segundo valor: ");
            string? SecondValue = Console.ReadLine();
             
            // retorna true se o valor for nulo ou uma string vazia
            if (!string.IsNullOrWhiteSpace(OneValue) && !string.IsNullOrWhiteSpace(SecondValue))
            {
                float OneValueNumber = float.Parse(OneValue);
                float SecondValueNumber = float.Parse(SecondValue);
               
                float Summation = OneValueNumber + SecondValueNumber;

                Console.WriteLine($"O resultado da soma é: {Summation}");
            }

            
        }
    }
    
}