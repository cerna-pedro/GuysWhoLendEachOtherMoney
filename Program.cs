namespace GuysWhoLendEachOtherMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if(int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe" || whichGuy == "joe" || whichGuy == "JOE")
                    {
                        bob.ReceiveCash(joe.GiveCash(amount));
                    }
                    else if (whichGuy == "Bob" || whichGuy == "bob" || whichGuy == "BOB")
                    {
                        joe.ReceiveCash(bob.GiveCash(amount));
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }

        }
    }
}