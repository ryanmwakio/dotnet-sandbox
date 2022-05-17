using System;

public class Program
{
    public static void Main(string[] args)
    {

        foreach (string drive in Environment.GetLogicalDrives())
            Console.WriteLine("Drive: {0}", drive);

        //get system details
        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of processors: {0}",

        Environment.ProcessorCount);
        Console.WriteLine(".NET Version: {0}",
        Environment.Version);
    }
}
