internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number of Rows:");

        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");

        for (int i = num; i > 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ", Convert.ToChar(j + 64));
            }
            Console.WriteLine("\n");
        }
    }
}