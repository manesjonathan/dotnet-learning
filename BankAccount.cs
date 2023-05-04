namespace helloWorld;

public class BankAccount
{
    private Client client;
    private double balance;
    private string type;

    public BankAccount(Client client, double balance, string type)
    {
        this.client = client;
        this.balance = balance;
        this.type = type;
    }

    public Client Client
    {
        get { return client; }
        set { client = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }


    public void CheckBalance()
    {
        Console.WriteLine("Your balance is " + Balance);
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
        Console.WriteLine("Your balance is now " + Balance);

    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Your balance is now " + Balance);

    }
}