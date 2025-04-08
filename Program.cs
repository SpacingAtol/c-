using System; //namespace

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter your age: ");
        
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nHello " + name);
        Console.WriteLine("Is your age "+ age +"?");

        Console.WriteLine("Enter the first number");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        float num2 = float.Parse(Console.ReadLine());

        float result = num1 / num2;
        Console.WriteLine($"\n The division of two number is {result}");

    }
}