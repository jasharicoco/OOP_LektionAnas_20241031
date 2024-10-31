namespace OOP_LektionAnas_20241031
{
    public sealed class SavingAccount : BankAccount
    {
        public decimal IntrestRate { get; set; }

        public SavingAccount(int accountNumber, decimal initialBalance, decimal intrestRate)
            : base(accountNumber, initialBalance)
        {
            IntrestRate = intrestRate;
        }

        public void ApplyIntrest()
        {
            decimal intrest = Balance * IntrestRate;

            Deposit(intrest);
            Console.WriteLine($"Intrest of {intrest:C} applied at rate {IntrestRate:P}." +
                $"New Balance: {Balance:C}");
        }

        // Overriding the Withdraw Method

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Withdraw denied");
                return;
            }

            base.Withdraw(amount);
        }

    }
}
