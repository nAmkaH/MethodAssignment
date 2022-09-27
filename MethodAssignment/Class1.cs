using System.Linq.Expressions;

namespace MethodAssignment
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer between 5 and 15: ");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 4) && (value_of_input <= 15))
                {
                    Console.WriteLine(value_of_input + "is" + input.ToString());
                }
                else
                {
                    Console.WriteLine("You must enter an integer number between 5 and 15 only.");
                    Console.WriteLine("Press any key to close the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Enter an integer number between 5 and 15 only.");
                int[] numbers = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                Console.WriteLine("Enter an integer number");
                int input = int.Parse(Console.ReadLine());

                foreach (int number in numbers)
                {
                    Console.WriteLine(" ");
                    int value = number;
                    Console.WriteLine(value);
                }
            }
        }
    }
}