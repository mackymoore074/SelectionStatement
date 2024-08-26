
using System;
using System.Security.Cryptography.X509Certificates;

static void Main(string[] args)
{
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
            Console.WriteLine("That's an interesting choice! Every subject has its own charm.");
            break; 
    }
}





