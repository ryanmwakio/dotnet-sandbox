using System;

public class Program
{
    public static void Main()
    {
        //intrinsic data types and new keyword
        int i = new int();
        bool b = new bool();
        double d = new double();
        DateTime dt = new DateTime();

        double myEps = double.Epsilon;

        //members of the System.Char class
        char myChar = 'a';
        Console.WriteLine(char.IsDigit(myChar));
        Console.WriteLine(char.IsWhiteSpace("Hello There", 5));

        ParseFromStrings();

    }

    // Parsing types
    static void ParseFromStrings()
    {
        Console.WriteLine("=> Data type parsing:");
        bool b = bool.Parse("True");

        Console.WriteLine("Value of b: {0}", b);
        double d = double.Parse("99.884");
        Console.WriteLine("Value of d: {0}", d);

        int i = int.Parse("8");
        Console.WriteLine("Value of i: {0}", i);

        char c = Char.Parse("w");
        Console.WriteLine("Value of c: {0}", c);

    }
}
