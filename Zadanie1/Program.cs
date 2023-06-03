public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj a:");
        a = inputValue();
        Console.WriteLine("Podaj b:");
        b = inputValue();
        Console.WriteLine("Podaj c:");
        c = inputValue();
        Console.WriteLine("Średnia arytmetyczna wynosi:");
        double sredniaArytmetyczna;

        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine(sredniaArytmetyczna);
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}