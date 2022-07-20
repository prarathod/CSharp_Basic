namespace EmployeeAPI.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public int Age { get; set; }
    }
}
