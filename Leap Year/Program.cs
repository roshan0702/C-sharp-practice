internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your Year");
        int year = Convert.ToInt32(Console.ReadLine());

        if (((year % 4 ==0) && (year % 100 == 0)) || (year % 400 == 0))
        {
            Console.WriteLine("{0} is a Leap Year",year);
        }

        else
        {
            Console.WriteLine("{0} is not a Leap Year", year);
        }
    }
}