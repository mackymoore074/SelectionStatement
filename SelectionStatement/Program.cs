
using System;
using System.Security.Cryptography.X509Certificates;

static void Main(string[] args)
{
    var r = new Random();
    //var favNumber = r.Next(1, 1000);
    Console.WriteLine("Guess my favorite number between 1 and 1000");
    var favNumber = 500;
    var userInput = int.Parse(Console.ReadLine());

    if (userInput < favNumber)
    {
        Console.WriteLine("too low");
    }
    else if (userInput > favNumber)
    {
        Console.WriteLine("too high");
    }
    else if (userInput == favNumber)
    {
        Console.WriteLine("you guessed it!!!");

    }

}





