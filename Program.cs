
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {

        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(1);
        CheckForPositiveNegativeZero(0);

        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);

        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);

        IsDivisibleBy5(5);
        IsDivisibleBy5(6);

        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);

        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');

        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);
 

    }

    public static void CheckForPositiveNegativeZero(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("Your number is positive.");
        }
        if (number < 0)
        {
            Console.WriteLine("Your number is Negative.");
        }
        if (number == 0)
        {
            Console.WriteLine("Your number is Zero.");
        }
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        int[] myNum = { num1, num2, num3 };
        Console.WriteLine("The minimum value is " + myNum.Min());

    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        int[] myNum = { num1, num2, num3 };
        Console.WriteLine("The maximum value is " + myNum.Max());
    }

    public static void IsDivisibleBy5(int number)
    {
        if ((number % 5) == 0)
        {
            Console.WriteLine(number + " is divisible by 5");
        }
        else
        {
            Console.WriteLine(number + " is not divisible by 5");

        }
    }

    public static void CheckEvenOrOdd(int number)
    {
        if ((number % 2) == 0)
        {
            Console.WriteLine(number + " is an even number");
        }
        else
        {
            Console.WriteLine(number + " is an odd number");

        }

    }

    public static void CheckVowelOrConsonant(char letter)
    {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            Console.WriteLine(letter + " is a vowel");
        else
            Console.WriteLine(letter + " is a Consonant");
    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        if (dayCode == 0)
        {
            Console.WriteLine("Sunday");

        }
        if (dayCode == 1)
        {
            Console.WriteLine("Monday");
        }
        if (dayCode == 2)
        {
            Console.WriteLine("Tuesday");

        }
        if (dayCode == 3)
        {
            Console.WriteLine("wednesday");

        }
        if (dayCode == 4)
        {
            Console.WriteLine("Thursday");

        }
        if (dayCode == 5)
        {
            Console.WriteLine("Friday");

        }
        if (dayCode == 6)
        {
            Console.WriteLine("Saturday");

        }

    }

}
