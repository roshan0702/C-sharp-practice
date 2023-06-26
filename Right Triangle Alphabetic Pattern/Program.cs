internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ", Convert.ToChar(j + 64));
            }
            Console.WriteLine("\n");
        }
    }
}