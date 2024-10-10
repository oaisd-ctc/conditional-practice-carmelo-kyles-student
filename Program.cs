
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {

        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
 
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
        
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {

    }

    public static void IsDivisibleBy5(int number)
    {

    }

    public static void CheckEvenOrOdd(int number)
    {

    }

    public static void CheckVowelOrConsonant(char letter)
    {

    }

}
