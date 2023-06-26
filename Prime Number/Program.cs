internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter your Number");
        long num = Convert.ToInt64(Console.ReadLine());
        bool prime = true;

        if (num == 0 || num == 1)
        {
            Console.WriteLine("{0} Number is not Prime", num);
        }
        else if (num == 2 || num == 3 || num == 5 || num == 7) 
        {
            Console.WriteLine("{0} Number is Prime", num);
        }
        else
        {
            if (num % 10 == 1 || num % 10 == 3 || num % 10 == 7 || num % 10 == 9)
            {
                for (long i = 3; i < Math.Sqrt(num) + 1; i += 2)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("{0} Number is not Prime", num);
                        prime = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("{0} Number is not Prime", num);
            }

            if (prime == true)
            {
                Console.WriteLine("{0} Number is Prime", num);
            }
        }

        
    }
}