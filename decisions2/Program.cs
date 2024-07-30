namespace decisions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, 3: ");
            string userValue = Console.ReadLine();

            string message = userValue == "1" ? "boat" : "strand of lint";

            Console.WriteLine("You won a ");
            Console.WriteLine(message + ".");
           
            Console.WriteLine();

            Console.WriteLine("Your won a {0}.", message);
            Console.WriteLine("You entered: {0}, therfore you won a {1}.", userValue, message);

            Console.ReadLine();
        }
    }
}