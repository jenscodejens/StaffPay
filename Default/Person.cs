using System;

namespace DefaultEncapsulation;

public class Person
{
    private string firstName = string.Empty;
    private string surname = string.Empty;
    private string email = string.Empty;
    private static int idCounter;
    private int monthlyPay;
    private int id;

    private static int IncreaseId()
    {
        return idCounter += 1;
    }

    #region
    public string FirstName
    {
        get { return firstName; }
        set
        {
            firstName = value;
        }
    }

    public string Surname
    {
        get { return surname; }
        set
        {
            surname = value;
        }
    }

    public int MonthlyPay
    {
        get { return monthlyPay; }
        set
        {
            monthlyPay = value;
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            email = value;
        }
    }
    public int Id
    {
        get { return id; }
        private set
        {
            id = IncreaseId();
        }
    }
#endregion

public Person(string firstName, string surname, string email, int monthlyPay, int id)
    {
        FirstName = firstName;
        Surname = surname;
        Email = email;
        MonthlyPay = monthlyPay;
        Id = id;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"\nName: \t{FirstName} {Surname}\nEmail: \t{Email}\nMontly pay: \t{MonthlyPay}\nId: \t{Id}\n");
    }
}

