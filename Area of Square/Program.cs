internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter length of Square");

        var Length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Area Of Square is: " + Length * Length);
    }
}