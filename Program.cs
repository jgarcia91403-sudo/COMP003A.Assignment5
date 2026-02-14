namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            ShowIntroduction(); // this will call the introduction method to display the welcome message when the program starts
            do
            {
                Console.Write(" Enter your name:");
                string name = Console.ReadLine();

                Console.Write(" Enter a whole number:");
                int number = Convert.ToInt32(Console.ReadLine());

                DisplayUserInfo(name, number);

                int result = CalculativeValue(number);

                Console.WriteLine(" Calculated result:" + result);

                if (result > 10) // this will check if the result is greater than 10 or less than and display a message accordingly
                {
                    Console.WriteLine(" The result is greater than 10.");
                }
                else
                {
                    Console.WriteLine(" The result is 10 or less. ");
                }
                Console.Write("\n Would you like to run the  program again? (y/n):"); // this will run the program again if you hit y and end it if you hit n
                repeat = Console.ReadLine();
                Console.WriteLine();
            } while (repeat.ToLower() == "y");
                {
                    Console.WriteLine("program ended.");
                }
                static void ShowIntroduction() // this will display a welcome message when you start the program
                {
                    Console.WriteLine(" Welcome to the program organizer!");
                    Console.WriteLine();
                }
                static void DisplayUserInfo(string username, int usernumber) // this method will display the user's name and the number they entered
                {
                    Console.WriteLine("\n Hello, " + username + "!");
                    Console.WriteLine(" You Entered: " + usernumber);
                }
                static int CalculativeValue(int value)
                {
                    int calculatedResult = value * 2; // this will multiply the number by 2 
                    return calculatedResult;
                }

        }
    }
}
