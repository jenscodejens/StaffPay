using System.Text.RegularExpressions;

namespace DefaultEncapsulation;
public class PersonValidator
{
    public static string inputFirstName = String.Empty;
    public static string inputSurname = String.Empty;
    public static string inputEmail = String.Empty;
    public static int inputPay = 0;

    public static void InputFirstName()
    {
        Console.Write("First name:\t");

        do
        {
            string input = Console.ReadLine()!;

            if (!string.IsNullOrWhiteSpace(input) && input.All(c => char.IsSeparator('-') || char.IsLetter(c)))
            {
                inputFirstName = input;
                break;
            }
            ClearPreviousConsoleLine();
            Console.Write("First name:\t");
        }
        while (true);
    }

    public static void InputSurname()
    {
        Console.Write("Surname:\t");

        do
        {
            string input = Console.ReadLine()!;

            if (!string.IsNullOrWhiteSpace(input) && input.All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
            {
                inputSurname = input;
                break;
            }
            ClearPreviousConsoleLine();
            Console.Write("Surname:\t");
        }
        while (true);
    }

    public static string InputEmail()
    {
        Console.Write("Email address:\t");

        do
        {
            string input = Console.ReadLine()!;

            if (IsValidEmail(input))
            {
                return inputEmail = input;
            }

            ClearPreviousConsoleLine();
            Console.Write("Email address:\t");
        }
        while (true);
    }

    public static void InputPay()
    {
        Console.Write("Monthly pay:\t");

        do
        {
            string foo = Console.ReadLine()!;
            string fooReplaced = foo.Replace(".", ",");

            if (Int32.TryParse(fooReplaced, out inputPay))
            {
                break;
            }
            ClearPreviousConsoleLine();
            Console.Write("Monthly pay:\t");
        }
        while (true);
    }

    private static bool IsValidEmail(string emailaddress)
    {
        return Regex.IsMatch(emailaddress, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
    }

    private static void ClearPreviousConsoleLine()
    {
        Console.CursorTop--;
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }
}



