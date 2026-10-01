using System;

class BankAccount
{
    protected decimal _balance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }
}

class SavingsAccount : BankAccount
{
    public void AddInterest(decimal rate)
    {
        _balance = _balance + (_balance * rate / 100);
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount account = new SavingsAccount();

        account.Deposit(10000);

        Console.WriteLine("Balance after deposit: " + account.GetBalance());

        account.AddInterest(5);

        Console.WriteLine("Balance after 5% interest: " + account.GetBalance());

    }
}