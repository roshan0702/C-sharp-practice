internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");
        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("   ");
            }
            for (int k = i; k <= rows; k++)
            {
                Console.Write("{0}     ", Convert.ToChar(k +64));
            }
            Console.WriteLine("\n");
        }
    }
}