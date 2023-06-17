internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your Number");

        int Num = Convert.ToInt32(Console.ReadLine());

        if (Num > 0)
        {
            Console.WriteLine("{0} is Positive Number", Num);
        }
        else if (Num == 0)
        {
            Console.WriteLine("{0} is nither Positive nor Negative Number", Num);
        }
        else
        {
            Console.WriteLine("{0} is Negative Number", Num);
        }
    }
}