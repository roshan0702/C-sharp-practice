internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number of Rows");
        int rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = rows; j > i ; j--) 
            {
                Console.Write("   ");
            }
            for (int k = 1; k <= i ; k++)
            {
                Console.Write(" *    ");
            }
            Console.WriteLine();
        }
    }
}