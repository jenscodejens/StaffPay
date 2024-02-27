namespace DefaultEncapsulation;

/* Eftersom jag inte ligger på en nivå som kräver att jag lär in snabbt, har jag suttit och övat.
 * Baserade dagens uppgift på lite kod jag skrev igår när jag läste om inkapsling.
 * Hade problem att få det att kompilera så all planerad input validation etc. ser ni lite hur jag
 * tänkt mig i filstruktuen, dettas hans inte med innan kl 16:30.
 * 
 * Vet inte hur jag skall få anropet på LoopEmployees() att fungera nu när tiden går ut.
 * Men ni ville få en måttstock så här kommer en basal inlämning som är helt
 * olik den planerade layouten (återingen, se filstrukturen).
 * Kommer fortsätta jobba med just detta för validering etc. har jag koll på,
 * det jag har problem med är att komma över trösklen där jag förstår exakt hur anropen
 * skall vara med static, ref, mellan olika klasser etc. och är inte riktigt där ännu. */


public class Program
{
    List<Person> employees = new List<Person>();
    public static void Main(string[] args)
    {


        char c;
        do
        {
            EmployeeFunctions();
            c = Console.ReadLine()[0];

            switch (c)
            {
                case '1':
                    AddUser();
                    break;
                case '2':
                    //LoopEmployees()
                    break;
                case 'q':
                    break;
                default:
                    Console.WriteLine("Enter: \"1\" \"2\" or \"3\"");
                    break;
            }
        } while (c != 'q');
    }

    static void EmployeeFunctions()
    {
        Console.WriteLine("Add emplyee: 1");
        Console.WriteLine("Display all emplyee(s): 2");
        Console.WriteLine("Quit: 3");
    }
    public static void AddUser()
    {
        string fn = String.Empty;
        string ln = String.Empty;
        int pay = 0;

        Console.WriteLine("Enter firstname: ");
        fn = Console.ReadLine();

        Console.WriteLine("Enter lastname: ");
        ln = Console.ReadLine();

        Console.WriteLine("Enter person's monthly pay:");
        pay = Convert.ToInt32(Console.ReadLine());

        Person person = new Person(fn, ln, pay);

        //FulFix(ref person);
    }

    //public void FulFix(ref Person person)
    //{
    //    employees.Add(person);
    //}

    public void LoopEmployees()
    {

        foreach (Person person in employees)
        {
            Console.WriteLine($"Name: {person.FirstName} {person.LastName} gets payed {person.MonthlyPay} of magical currency each month.");
        }
    }
}








//Person person1 = new Person("777", "Kaknylle", "adamg@mail.com", 0);
//Person person2 = new Person("Sven-Benny", "Muppet", "bethany@snowball.se", 0);
//Person person3 = new Person("ACDC", "Rock", "kaka@svett.se", 0);

//person1.DisplayDetails();
//person2.DisplayDetails();
//person3.DisplayDetails();
//person.DisplayDetails();
//Console.ReadLine();

