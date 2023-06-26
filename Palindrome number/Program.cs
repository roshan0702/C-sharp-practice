internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your number");
        long num = Convert.ToInt64(Console.ReadLine());
        long i = num;
        long r;
        long pal = 0;

        while(i > 0)
        {
            r = i % 10;
            pal = pal * 10 + r;
            i = i / 10;
        }

        if (pal == num)
        {
            Console.WriteLine("{0} is Palindrome", num);
        }
        else
        {
            Console.WriteLine("{0} is not Palindrome", num);
        }
    }
}