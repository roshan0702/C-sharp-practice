internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your Number");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Factorial of Number {0} is :", num);
        double fact = 1;
        if (num == 0)
        {
            Console.WriteLine(fact);
        }
        else if (num < 0)
        {
            Console.WriteLine("Enter number greater than 0");
        }
        else
        {
            while (num > 0)
            {
                fact *= num;
                num -= 1;
            }
            Console.WriteLine(fact);
        }
    }
}