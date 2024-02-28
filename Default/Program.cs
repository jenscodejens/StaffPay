namespace DefaultEncapsulation;

public class Program
{
    static void Main(string[] args)
    {

        char menuInput = '\0';

        while (menuInput != 'q')
        {
            Console.Clear();    
            Console.WriteLine(("employee menu\n").ToUpper());
            Console.WriteLine("(1)  Add employee");
            Console.WriteLine("(2)  Display all employee(s)");
            Console.WriteLine("(q)  Quit\n");
            Console.Write("Selection: ");

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
                        Console.WriteLine(">>Invalid selection<<");
                        break;
                }
            }
        }
    }
}





