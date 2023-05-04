/*// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, who are you?");

var name = Console.ReadLine();

Console.WriteLine("Hello " + name + "! How are you?");

var answer = Console.ReadLine();

Console.WriteLine("I feel " + answer + " as well " + name);

Console.WriteLine("Do you have any other questions?");

var input = Console.ReadLine();

if (input != null && input.Contains("date"))
{
    Console.WriteLine("The date is " + DateTime.Now);
}
else
{
    Console.WriteLine("What is your age?");
}

var age = Console.ReadLine();*/

using helloWorld;

Client client = new Client(0, "Jonathan", DateTime.Now);
BankAccount bankAccount = new BankAccount(client, 1000, "Savings");

bankAccount.CheckBalance();
bankAccount.Deposit(45.50);
bankAccount.Withdraw(25);