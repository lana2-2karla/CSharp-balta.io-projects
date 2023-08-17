namespace EmployeeSystem
{
    public class Employees
    {
        // Atributos

        private Guid id { get; set; } = Guid.NewGuid();
        private string firstName { get; set; } = "Allana";
        private string lastName { get; set; } = "Justino";
        private string position { get; set; } = "Developer";
        private string manager { get; set; } = "Larissa Torres";
        
        // Métodos Especiais

        //Métodos
       // public abstract double CalculateSalary();
   
       public void RequestRelease()
       {
            var date = DateTime.Now;
            Console.WriteLine(date);
       }

       // public abstract string AskForRaise();

    }
}