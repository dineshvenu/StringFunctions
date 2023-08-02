// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");

StringFunctions stringFunctions = new StringFunctions();

stringFunctions.FindDuplicateChar1("Hello, World!");

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

    public void FindDuplicateChar1(string Text)
    {
        var chars=new List<char>(); 
        foreach(char c in Text) { 

            if(Text.IndexOf(c)!=Text.LastIndexOf(c) && !chars.Contains(c))
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