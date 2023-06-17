internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        double second = Convert.ToDouble(Console.ReadLine());
        double hcf = 0;

        if (first > second)
        {
            for (double i = 1; i <= second; i++) 
            { 
                if (first % i == 0 && second % i == 0)
                {
                    hcf = i;
                }
            }
        }
        else
        {
            for (int i = 1; i <= first; i++)
            {
                if (first % i == 0 && second % i == 0)
                {
                    hcf = i;
                }
            }
        }
        Console.WriteLine(hcf + " is the HCF");
    }
}