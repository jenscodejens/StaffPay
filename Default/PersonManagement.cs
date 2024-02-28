namespace DefaultEncapsulation;
public class PersonManagement
{
    public static List<Person> listOfEmployees = new List<Person>();
    public static void CreateNewPerson()
    {
        Console.Clear();
        Console.WriteLine(("add new employee\n").ToUpper());
        PersonValidator.InputFirstName();
        PersonValidator.InputSurname();
        PersonValidator.InputEmail();
        PersonValidator.InputPay();

        Person person = new Person(PersonValidator.inputFirstName, PersonValidator.inputSurname, PersonValidator.inputEmail, PersonValidator.inputPay, 0);

        Console.WriteLine("\n>>Employee added to the ledger<<");
        listOfEmployees.Add(person);
        Console.ReadLine();
    }

    public static void DisplayDetails()
    {
        Console.Clear();

        Console.WriteLine(("employees in the ledger").ToUpper());

        if (listOfEmployees.Count > 0)
        {
            foreach (var person in PersonManagement.listOfEmployees)
            {
                Console.WriteLine($"\nName: \t{person.FirstName} {person.Surname}\nEmail: \t{person.Email}\nSalery: {person.MonthlyPay}\nId: \t{person.Id}");
            }
        }
        else
        {
            Console.WriteLine("No current record");
        }
        Console.WriteLine("\n>>End of ledger<<");
        Console.ReadLine();
    }
}

// Metod: Ta bort person

// Metod: ändra förnamn

// Metod: ändra efternamn

// Metod: ändra email

// Metod: ändra lön