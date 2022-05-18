using System;

public class Program
{
    public static void Main(string[] args)
    {
        //getting the logical drives
        foreach (string drive in Environment.GetLogicalDrives())
            Console.WriteLine($"Drive: {drive}");

        //string verbatim
        string filePath = @"C:\televisions\sony\bravia.txt";

        //underscore seperator
        int myInt = 1_000_000;

        //some members of the Console class
        Console.Title = "My first console app";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WindowHeight = 40;
    }
}
