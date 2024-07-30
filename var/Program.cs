namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(x);
            */

            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name: ");
            string myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine(); // pause program

        }
    }
}