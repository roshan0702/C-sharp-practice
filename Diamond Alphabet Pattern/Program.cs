internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");

        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= num - i; j++)
            {
                Console.Write("   ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("{0}     ", Convert.ToChar(k + 64));
            }
            Console.WriteLine("\n");
        }

        for (int i = num -1; i >= 1; i--)
        {
            for (int j = 1; j <= num - i; j++)
            {
                Console.Write("   ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("{0}     ", Convert.ToChar(k + 64));
            }
            Console.WriteLine("\n");
        }
    }
}