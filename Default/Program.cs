using System;

namespace DefaultEncapsulation;

public class Program
{
    static void Main(string[] args)
    {

        char menuInput = '\0';
        while (menuInput != 'q')
        {
            Console.WriteLine("Employee menu");
            Console.WriteLine("(1)\tAdd employee");
            Console.WriteLine("(2)\tDisplay all employee(s)");
            Console.WriteLine("(q)\tQuit:\n");
            Console.Write("Make your pick: ");

            if (char.TryParse(Console.ReadLine().ToLower(), out menuInput))
            { 
                switch (menuInput)
                {
                    case '1':
                        PersonManagement.CreateNewPerson();
                        break;
                    case '2':
                        PersonManagement.DisplayDetails();
                        break;
                    case 'q':
                        break;
                    default:
                        Console.WriteLine("Make a valid menue selection.");
                        break;
                }
            }
        }
    }
}





