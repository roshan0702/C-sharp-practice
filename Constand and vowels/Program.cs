using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your text");
        string Str = Console.ReadLine();

        int numConst = 0, numVowels = 0;

        for (int i = 0; i < Str.Length; i++) 
        {
            if (Str[i] == 'a' || Str[i] == 'e' || Str[i] == 'i' || Str[i] == 'o' || Str[i] == 'u' || Str[i] == 'A' ||
            Str[i] == 'E' || Str[i] == 'I' || Str[i] == 'O' || Str[i] == 'U')
            {
                numVowels++;
            }
            else if ((Str[i] >= 'a' && Str[i] <= 'z') ||
                 (Str[i] >= 'A' && Str[i] <= 'Z'))
            {
                numConst++;
            }
        }

        Console.WriteLine("count of vowel = " + numVowels);
        Console.WriteLine("count of consonant = " + numConst);
    }
}