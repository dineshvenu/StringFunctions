// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");

StringFunctions stringFunctions = new StringFunctions();

Console.WriteLine(stringFunctions.FindDuplicateChar("Hello, World!"));

public class StringFunctions
{
    public StringBuilder FindDuplicateChar(string Text)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder dupChar = new StringBuilder();
        foreach (char c in Text)
        {
            if (result.ToString().IndexOf(c.ToString().ToLower()) == -1)
            {
                result.Append(c);
            }
            else
                if (dupChar.ToString().IndexOf(c.ToString().ToLower()) == -1)
                dupChar.Append(c);
        }
        return dupChar;
    }
}