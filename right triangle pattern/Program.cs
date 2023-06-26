internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows :");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine("\n");
        }
    }
}