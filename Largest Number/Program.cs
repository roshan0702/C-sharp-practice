internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your First number");
        int num1 = Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine("Enter your Second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Third number");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Fourth number");
        int num4 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                if (num1 > num4)
                {
                    Console.WriteLine("{0} is largest number", num1);
                }
                else
                {
                    Console.WriteLine("{0} is largest number", num4);
                }
            }
        }
        else if (num2 > num3)
        {
            if (num2 > num4)
            {
                Console.WriteLine("{0} is largest number", num2);
            }
            else
            {
                Console.WriteLine("{0} is largest number", num4);
            }
        }
        else if ( num3 > num4)
        {
            Console.WriteLine("{0} is largest number", num3);
        }
        else
        {
            Console.WriteLine("{0} is largest number", num4);
        }
    }
}