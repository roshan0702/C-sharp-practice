internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your number");
        long num = Convert.ToInt64(Console.ReadLine());
        long i = num, j = num,  r = 0;
        double  sum = 0;
        int count = 0;

        while (i > 0)
        {
            count++;
            i /= 10;
        }

        while (j > 0)
        {
            r = j % 10;
            sum += Math.Pow(r, count);

            j /= 10;
        }

        if (sum == num)
        {
            Console.WriteLine("{0} is the armstrong Number",num);
        }
        else
        {
            Console.WriteLine("{0} is not the armstrong Number", num);
        }
    }
}