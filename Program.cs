namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowIntroduction();
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
            }

        }
    }
}
