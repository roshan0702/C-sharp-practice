internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows :");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
        for (int i = 1; i <= rows; i++)
        {
            for (int j = rows - i; j >= 1; j--)
            {
                Console.Write("   ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine("\n");
        }
    }
}