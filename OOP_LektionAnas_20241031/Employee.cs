namespace OOP_LektionAnas_20241031
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _salary;
        private string _gender;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void DisplayFullName()
        {
            Console.WriteLine(@"Full Name: {0} {1}", _firstName, _lastName);
        }

        public void DisplayEmoyeeData()
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"First Name: {_firstName}");
            Console.WriteLine($"Last Name: {_lastName}");
            Console.WriteLine($"Salary: {_salary}");
        }
    }
}
