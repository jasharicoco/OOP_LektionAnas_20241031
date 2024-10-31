namespace OOP_LektionAnas_20241031
{

    struct Book
    {
        public int Id;
        public string Title;
        public string Author;
        public string Subject;

        public void DisplayData()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Subject: {Subject}");
        }


    }

    interface IStudent
    {

    }

    struct Student : IStudent
    {
        private int _id;
        private string _name;

        public int ID { get => _id; set => _id = value; }

        public string Name { get => _name; set => _name = value; }

        public Student(int i, string n)
        {
            _id = i;
            _name = n;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {_id}\n Name: {_name}");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee();
            //PartialEmployee emp2 = new PartialEmployee();

            //emp2.FirstName = "John";
            //emp2.LastName = "Doe";
            //emp2.Salary = 12000d;
            //emp2.Gender = "Shemale";

            //emp2.DisplayEmoyeeData();



            //Utility u = new Utility();
            //u.PrintMessage("Hello World!");

            //C c = new C();
            //c.GetInfo(); // hämtar GetInfo från B-klassen eftersom C ärver från B.



            // Create a Savings Account

            //SavingAccount savingAccount = new SavingAccount(1234, 1000m, 0.5m);
            //savingAccount.Deposit(200);
            //savingAccount.Withdraw(50m);
            //savingAccount.ApplyIntrest();


            //Console.ReadKey();


            // Struct

            Book book1;
            Book book2;
            Book book3;

            //Book 1
            book1.Id = 1;
            book1.Title = "C# Programming";
            book1.Author = "John Doe";
            book1.Subject = "Programming";
            book1.DisplayData();

        }
    }

    public sealed class Utility
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }


        ~Utility()
        {
            Console.WriteLine("Utility destructor called");
        }
    }

    public class A /*: Utility*/
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base Class A Method");
        }

        public virtual void Test()
        {
            Console.WriteLine("Base Class A Test Method");
        }
    }

    public class B : A
    {
        public sealed override void GetInfo()
        {
            Console.WriteLine("Derived Class B Method");
        }

        public override void Test()
        {
            Console.WriteLine("Derived Class B Test Method");
        }
    }

    public class C : B
    {
        //public override void GetInfo()
        //{
        //    Console.WriteLine("Derived Class C Method");
        //}

        public override void Test()
        {
            Console.WriteLine("Derived Class C Test Method");
        }
    }

}
