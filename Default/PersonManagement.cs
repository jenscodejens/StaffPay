using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultEncapsulation;
public class PersonManagement
{
    public static List<Person> listOfEmployees = new List<Person>();
    public static void CreateNewPerson()
    {
        //var person = new Person();


    PersonValidator.InputFirstName();
        PersonValidator.InputSurname();
        PersonValidator.InputEmail();
        PersonValidator.InputPay();

        Person person = new Person(PersonValidator.inputFirstName, PersonValidator.inputSurname, PersonValidator.inputEmail, PersonValidator.inputPay, 0);

        listOfEmployees.Add(person);
        Console.ReadLine(); 

        // Hur callar jag AddPersonToList i klassen Person?
    }

    public static void DisplayDetails() 
    {
        foreach (var person in PersonManagement.listOfEmployees)
        {

            Console.WriteLine($"\nName: \t{person.FirstName} {person.Surname}\nEmail: \t{person.Email}\nMontly pay: \t{person.MonthlyPay}\nId: \t{person.Id}\n");
        }
        Console.ReadLine();
    }
}



// Metod: Ta bort person

// Metod: ändra förnamn

// Metod: ändra efternamn

// Metod: ändra email

// Metod: ändra lön