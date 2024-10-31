namespace OOP_LektionAnas_20241031
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }


        public BankAccount(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;

            Console.WriteLine($"Deposited {amount:C} to account {AccountNumber}.\n" +
                $"New balance is {Balance:C}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"Unsufficient funds on account.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from account {AccountNumber}.\n" +
                $"New balance is {Balance:C}");
        }
    }
}
