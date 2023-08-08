// See https://aka.ms/new-console-template for more information

using System.Text;
using static System.Net.Mime.MediaTypeNames;

//Console.WriteLine("Hello, World!");

StringFunctions stringFunctions = new StringFunctions();

stringFunctions.ReverseWords("Hello, World!");

public class StringFunctions
{
    public void ReverseWords(string originalString)
    {
        StringBuilder sb = new StringBuilder(); 
        string[] strings = originalString.Split(" ");
        foreach (string s in strings)
        {
            string result = "";
            for(int i=s.Length-1; i>=0; i--)
            {
                result += s[i];
            }
            sb.Append(result);
            sb.Append(" ");
        }
        Console.WriteLine(sb.ToString());
    }
    public void Reverse(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        string result = new String(chars);

        //string result = "";
        //for(int i=s.Length-1; i>=0;i--)
        //{
        //    result += s[i];
        //}
        Console.WriteLine(result);
    }
    public void UniquwChar(string s)
    {

    }
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

    public void FindDuplicateChar1(string Text)
    {
        var chars = new List<char>();
        foreach (char c in Text)
        {

            if (Text.IndexOf(c) != Text.LastIndexOf(c) && !chars.Contains(c))
            {
                chars.Add(c);
            }

        }
        Console.WriteLine(string.Join(",", chars));

    }
    public void FindDuplicateChar2(string s)
    {
        var groups = s.GroupBy(c => c).Where(g => g.Count() > 1);
        foreach (var group in groups)
        {
            Console.WriteLine(group.Key);
        }
    }


}