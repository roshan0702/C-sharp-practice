internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your character");
        Char Ch = Convert.ToChar(Console.ReadLine());

        if (Ch == 'a' || Ch == 'e' || Ch == 'i' || Ch == 'o' || Ch == 'u' || Ch == 'A' || Ch == 'E' || Ch == 'I' || Ch == 'O' || Ch == 'U')
        {
            Console.WriteLine("Character is  Vowel");
        }
        else
        {
            Console.WriteLine("Character is Constant");
        }
    }
}