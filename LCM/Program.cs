using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter your First Number");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please Enter your Second Number");
        double second = Convert.ToDouble(Console.ReadLine());
        double LCM, hcf = 1;
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
        LCM =(first / hcf) * second;
        Console.WriteLine("LCM of {0} and {1} is : {2}", first, second, LCM);
    }
}