internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your Number");
        int Num = Convert.ToInt32(Console.ReadLine());
        int Sum = 0;
        int ONum = Num;

        while (Num > 0)
        {
            Sum += Num % 10;
            Num /= 10;
        }
        Console.WriteLine(" Sum of digits on {0} is {1}", ONum, Sum);
    }
}