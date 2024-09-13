namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(20000);


            account.Deposit(100);
            account.Deposit(-200);

            account.Withdraw(500);
            account.Withdraw(250000);



        }
    }

    public class BankAccount
    {
        public double balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount}. Current balance: {balance}.");
            }
            else
                Console.WriteLine("Amount must be positive.");
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew {amount}. Current balance: {balance}.");
                }
                else
                    Console.WriteLine("Insufficient funds.");
            }
            else
                Console.WriteLine("Amount must be positive.");
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Current balance: {balance}.");
        }
    }
    public class Car
    {
        private int Speed;

        public void Accelerate(int amount)
        {
            if (amount > 0)
                Speed += amount;
        }

        public void Brake()
        {
            Speed = 0;
        }
    }
}
