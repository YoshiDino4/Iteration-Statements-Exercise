namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThouScale()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountByThrees()
        {
            for (int n = 3; n <= 999; n += 3)
            {
                Console.WriteLine(n);
            }
        }
        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void EqualInt(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("These integers are the same");
            }
            else
            {
                Console.WriteLine("These integers are not the same");
            }
        }
        
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int number)
        {
            if (number >= 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else
            {
                Console.WriteLine($"{number} is negative");
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VoteStatus(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range(int number)
        {
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is in the range -10 to 10");
            }
            else
            {
                Console.WriteLine($"{number} is not in the range of -10 to 10");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThouScale();
            CountByThrees();
            
            // EqualInt example
            EqualInt(10, 10);
            EqualInt(10, 20);
            
            // EvenOrOdd example
            Console.WriteLine("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            EvenOrOdd(number);
            
            // PositiveOrNegative example
            PositiveOrNegative(10);
            PositiveOrNegative(-10);
            
            // VoteStatus example
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            VoteStatus(age);
            
            // Range example
            Range(5);
            Range(15);
            
            // Multiplication Table example
            Console.WriteLine("Enter an integer to display its multiplication table:");
            number = int.Parse(Console.ReadLine());

            MultTable(number);

        }
    }
}
