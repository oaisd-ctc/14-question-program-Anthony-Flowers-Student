// See https://aka.ms/new-console-template for more information
using System;


public class Program
{   

    static string name;
    static int futureage;
    static string eyecolor;
    static string shoesize;
    static string favcolor;
    static string favmovie;
    static string favteacher;
    static string favclass;
    static string favholiday;
    static string favseason;
    static string dreamjob;
    static string age;
    static int sibilings;
    static int agein5years;
    static string haircolor;


    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSibilings();
        DisplaySummaryMessage();

    }
    public static void AskName() {
        Console.WriteLine("What is your name?");
         name = Console.ReadLine();
    }
    public static void AskAge() {
        Console.WriteLine("What is your age?");
         age = Console.ReadLine();
    }
    public static void AskEyeColor() {
        Console.WriteLine("What is your eye color?");
         eyecolor = Console.ReadLine();
    }
    public static void AskHairColor(){
        Console.WriteLine("What is your hair color?");
        haircolor = Console.ReadLine();
    }
    public static void AskShoeSize() {
        Console.WriteLine("What is your shoe size?");
         shoesize = Console.ReadLine();
    }
    public static void AskFavoriteColor() {
        Console.WriteLine("What is your favorite color?");
         favcolor = Console.ReadLine();
    }
    public static void AskFavoriteTvShow() {
        Console.WriteLine("What is your favorite movie or tv show?");
         favmovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher() {
        Console.WriteLine("Who is your favorite teacher?");
         favteacher = Console.ReadLine();
    }
    public static void AskFavoriteClass() {
        Console.WriteLine("What is your favorite class");
         favclass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday() {
        Console.WriteLine("What is your favorite holiday?");
         favholiday = Console.ReadLine();
    }
    public static void AskFavoriteSeason() {
        Console.WriteLine("What is your favorite season?");
         favseason = Console.ReadLine();
    }
    public static void AskDreamJob() {
        Console.WriteLine("What is your dream job?");
         dreamjob = Console.ReadLine();
    }
    public static void CalculateAgeIn5Years(string age) {
         agein5years = Convert.ToInt32(age) + 5;
         
    }
    public static void AskNumberOfSibilings() {
        Console.WriteLine("How many sibilings do you have?");
         sibilings = Convert.ToInt32(Console.ReadLine());
    }
    public static void DisplaySummaryMessage() {
  Console.WriteLine("Hello, " + name + ". You will be " + agein5years + " years old in 5 years. You have beautiful " + eyecolor + " eyes and amazing " + haircolor +" hair. Your shoe size is " + shoesize +
         " and your favorite color is " + favcolor + ". Your favorite movie/tv show is " + favmovie + ". Your favorite teacher is NOT Mr. Martinez, but actually "
          + favteacher + ", and your favorite class is " + favclass + ". Your favorite holiday is, " + favholiday + ", and you love " + favseason + ". Your dream job is "
           + dreamjob + ". You have " + sibilings + " sibilings.(I'm sorry about that btw).");
    }
}
