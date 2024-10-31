namespace OOP_LektionAnas_20241031
{
    internal partial class PartialEmployee
    {
        public void DisplayEmoyeeData()
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"First Name: {_firstName}");
            Console.WriteLine($"Last Name: {_lastName}");
            Console.WriteLine($"Salary: {_salary}");
        }
    }
}
