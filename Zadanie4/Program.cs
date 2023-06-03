public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d, x, y;

        Console.WriteLine("Wpisz a:");
        a = (int)inputValue();
        Console.WriteLine("Wpisz b:");
        b = (int)inputValue();
        Console.WriteLine("Wpisz c:");
        c = (int)inputValue();
        Console.WriteLine("Wpisz d:");
        d = (int)inputValue();

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązań");
        }
        else
        {
            x = ((a * d) + (b * c));
            y = (b * d);
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
        }
    }
    private static double inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}