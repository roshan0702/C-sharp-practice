internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, swap;
        Console.WriteLine("Please enter your first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter your second number");
        num2 = Convert.ToInt32(Console.ReadLine());

        swap = num1;
        num1 = num2;
        num2 = swap;

        Console.WriteLine("new num1 = " +  num1);
        Console.WriteLine("new num2 = " + num2);

    }
}