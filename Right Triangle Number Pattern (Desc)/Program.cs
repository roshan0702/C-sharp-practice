internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");

        for (int i = num; i >= 1; i--)
        {
            for (int j = num; j >= i; j--) 
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine("\n");

        }
    }
}