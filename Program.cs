// See https://aka.ms/new-console-template for more information
using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your eye color?");
        string eyecolor = Console.ReadLine();
        Console.WriteLine("What is your shoe size?");
        string shoesize = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        string favcolor = Console.ReadLine();
        Console.WriteLine("What is your favorite movie or tv show?");
        string favmovie = Console.ReadLine();
        Console.WriteLine("Who is your favorite teacher?");
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
        Console.WriteLine("Hello, " + name + ". You are " + age + " years old. You have beautiful " + eyecolor + " eyes. Your shoe size is " + shoesize + " and your favorite color is " + favcolor + ". Your favorite movie/tv show is " + favmovie + ". Your favorite teacher is NOT Mr. Martinez, but actually" + favteacher + ", and your favorite class is " + favclass + ". Your favorite holiday is, " + favholiday + ", and you love " + favseason + ". Your dream job is " + dreamjob + ". You have " + sibilings + " sibilings.(I'm sorry about that btw).");
    }
}
