namespace DefaultEncapsulation;

public class Person
{
    private string firstName = string.Empty;
    private string lastName = string.Empty;
    private string email = string.Empty;
    private static int idCounter;
    private int monthlyPay;
    private int id;

    private static int IncreaseId()
    {
        return idCounter += 1;
    }

    //    (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))


    public string FirstName
    {
        get { return firstName; }
        set
        {
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            lastName = value;
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

    public Person(string firstName, string lastName, int monthlypay)
    //public Person(string firstName, string lastName, string email, int id)
    {
        FirstName = firstName;
        LastName = lastName;
        //Email = email;
        //Id = id;
        MonthlyPay = monthlyPay;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"\nName: \t{FirstName} {LastName}\nMontly Pay: \t{MonthlyPay}");
        //Console.WriteLine($"\nName: \t{FirstName} {LastName}\nEmail: \t{Email}\nId: \t{Id}\n");
    }

}

