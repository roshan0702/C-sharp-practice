internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your character");
        Char Ch = Convert.ToChar(Console.ReadLine());

        if ((Ch >= 'a' && Ch <= 'z') || (Ch >= 'A' && Ch <= 'Z'))
        {
            Console.WriteLine("Character is  Alphabet");
        }
        else
        {
            Console.WriteLine("Character is not Alphabet");
        }
    }
}