namespace decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                message = "You won a new boat!";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                message = "You won a new cat!";
                Console.WriteLine(message);
            }
            else
            {
                message = "Sorry, we didn't understand.";
                Console.WriteLine(message);
            }

            Console.ReadLine();
        }
    }
}