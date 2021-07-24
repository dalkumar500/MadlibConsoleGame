using System;
namespace MadlibConsoleGame
{
    static class MConsole
    {
        //declare variables
        static string  Name;
        static string  Repeatname;
        static string AnimalName;
        static string Noun;
        static string GenreTypeofMovie;
        static string Profession;
        public static void Run()
        {
            Start();
            GetWords();
            Story();
            Exit();
        }
        static void Start()
        {
            // Write header and instructions
            Console.WriteLine("         ......Welcome To The Madlib Game......       ");
            // Ask the player enter words
        }
        static void GetWords()
        {
            Console.WriteLine("please enter a Name:");
            Name = Console.ReadLine();
           
            Console.WriteLine("please enter a Repeatname:");
            Repeatname = Console.ReadLine();
           
            Console.WriteLine("please enter a AnimalName:");
            AnimalName = Console.ReadLine();

            Console.WriteLine("please enter a Noun:");
            Noun = Console.ReadLine();

            Console.WriteLine("please enter a GeneTypeofMovie:");
            GenreTypeofMovie = Console.ReadLine();
            
            Console.WriteLine("please enter a Profession:");
            Profession = Console.ReadLine();

            Console.WriteLine("..Press enter to read your wacky new take on Hey Diddle Diddle!");

            Console.ReadLine();
        }


        static void Story()
        {
            // Write out Story

            Console.WriteLine("Hey" +" "+ Name+" " +Repeatname);
            Console.WriteLine("The" +" " +AnimalName +" "  +"and the fiddle");
            Console.WriteLine("The " + Noun +" "+"jumped over the moon");
            Console.WriteLine("The little dog laughed to see such" +" "+GenreTypeofMovie);
            Console.WriteLine("And the dish ran away with" + " "+Profession);
        }
        static void Exit()
        {
            // Keep window open  enter for  Exit
            Console.WriteLine("...Press enter to exit...");

            Console.ReadKey();
        }

        class Program
        {
            static void Main()
            {
                MConsole.Run();

            }
        }
    }
}

   



 