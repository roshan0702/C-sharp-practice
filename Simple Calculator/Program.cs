internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter:");
        Console.WriteLine("1 for Addition operation");
        Console.WriteLine("2 for Subtraction operation");
        Console.WriteLine("3 for Multiplication operation");
        Console.WriteLine("4 for Division operation");

        int operation = Convert.ToInt32(Console.ReadLine());
        if (operation == 1 ||  operation == 2 || operation == 3 || operation == 4) 
        {
            Console.WriteLine("Please Enter your first number");
            long num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter your second number");
            long num2 = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine("The addition of numbers is :  " + (num1 + num2));
            }
            else if (operation == 2)
            {
                Console.WriteLine("The Subtraction of numbers is :  " + (num1 - num2));
            }
            else if (operation == 3)
            {
                Console.WriteLine("The Multiplication of numbers is :  " + (num1 * num2));
            }
            else
            {
                Console.WriteLine("The Division of numbers is :  " + (num1 / num2));
            }

        }
        else
        {
            Console.WriteLine("Please Enter Valid operation code");
        }
    }
}