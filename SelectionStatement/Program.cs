/*
 * Create a program that allows a user to play a game where they must guess what your favorite number is:

Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
var r = new Random();
var favNumber = r.Next(1,1000);
var userInput = int.Parse(Console.ReadLine());
The following code will allow the user to guess what your favorite number is:

var userInput = int.Parse(Console.ReadLine());
Create an if-statement that if the guessed number is below the initial value, print out “too low”.

Create an else-if statement that if the number is higher than the initial value, print out “too high”.

Create an else statement that prints out some type of congratulations for guessing the correct number e.g. “You guessed it!!!”.
*/

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


    Console.WriteLine ("what is your favorite subject?");

        string subject = Console.ReadLine();

    switch (subject)
    {
        case "Math":
            Console.WriteLine("Math is a great subject");
            break;
        case "Science":
            Console.WriteLine("Science is a nice subject");
            break;
        case "History":
            Console.WriteLine("History is a great subject to historical Heritage");
            break;
        case "English":
            Console.WriteLine("English is a great subject to improve vocabulary");
            break;
        case"Art":
            Console.WriteLine("Art is a great subject to show talent");
            break;
        default:
            Console.WriteLine("Interesting choice! What do you like about it?");
            break; ;
    }
}





