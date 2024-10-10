// See https://aka.ms/new-console-template for more information
using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name? (Letters only)");
        string name = Console.ReadLine();
        Console.WriteLine("What is your age? (Numbers only)");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your eye color? (Letters only)");
        string eyecolor = Console.ReadLine();
        Console.WriteLine("What is your shoe size? (Letters only)");
        string shoesize = Console.ReadLine();
        Console.WriteLine("Wat is your favorite color? (Letters only)");
        string favcolor = Console.ReadLine();
        Console.WriteLine("What is your favorite movie or tv show?");
        string favmovie = Console.ReadLine();
        Console.WriteLine("Who is your favorite teacher? (Letters Only)");
        string favteacher = Console.ReadLine();
        Console.WriteLine("What is your favorite class");
        string favclass = Console.ReadLine();
        Console.WriteLine("What is your favorite holiday?");
        string favholiday = Console.ReadLine();
        Console.WriteLine("What is your favorite season?");
        string favseason = Console.ReadLine();
        Console.WriteLine("What is your dream job?");
        string dreamjob = Console.ReadLine();
        Console.WriteLine("How many sibilings do you have?");
        int sibilings = Convert.ToInt32(Console.ReadLine());
    }
}
