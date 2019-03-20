using System;
public class Substring_Broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        const char p = 'р';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
            if (text[i] == (char)112)
            {
                hasMatch = true;
                int endIndex = jump + 1;
                if (i + jump >= text.Length)
                    endIndex = text.Length - i;
                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump;
            }
        
        if (!hasMatch)
            Console.WriteLine("no");
    }
}
