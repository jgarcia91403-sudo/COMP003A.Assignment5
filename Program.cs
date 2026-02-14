namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";
            while (repeat == "y")
            {
                Console.Write(" Enter your name:");
                string name = Console.ReadLine();
                Console.Write(" Enter a whole number:");
                int number = Convert.ToInt32(Console.ReadLine());
                DisplayUserInfo(name, number);
                int result = CalculativeValue(number);
                Console.WriteLine(" Calculated result:" + result);
                if (result > 10)
                {
                    Console.WriteLine(" The result is greater than 10.");
                }
                else
                {
                    Console.WriteLine(" The result is 10 or less. ");
                }
                Console.Write("\n Would you like to run the  program again? (y/n):");
                repeat = Console.ReadLine();
                Console.WriteLine();
                {
                    Console.WriteLine("program ended.");
                }
                static void ShowIntroduction()
                {
                    Console.WriteLine(" Welcome to the program organizer!");
                    Console.WriteLine();
                }
                static void DisplayUserInfo(string username, int usernumber)
                {
                    Console.WriteLine("\n Hello, " + username + "!");
                    Console.WriteLine(" You Entered: " + usernumber);
                }
                static int CalculativeValue(int value)
                {
                    int calculatedResult = value * 2;
                    return calculatedResult;
                }
            }

        }
    }
}
