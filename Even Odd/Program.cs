internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your Number");

        int Num = Convert.ToInt32(Console.ReadLine());

        if (Num % 2 == 0)
        {
            Console.WriteLine("{0} is Even Number", Num);
        }
        else
        {
            Console.WriteLine("{0} is Odd Number", Num);
        }
    }
}