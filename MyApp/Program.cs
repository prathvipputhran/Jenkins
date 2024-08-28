using MyApp;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(5, 3);
        Console.WriteLine($"The result of adding 5 and 3 is: {result}");
    }
}
