internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your Number");
        long num = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Table of number {0} is :", num);

        for (int i = 1; i<=10; i++)
        {
            Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
        }
    }
}