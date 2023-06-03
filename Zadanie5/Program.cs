using System.Transactions;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Podaj a");
        a=double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b:");
        b=double.Parse(Console.ReadLine());
        if (a == b) Console.WriteLine("Liczba "+a+" jest równa liczbie "+b);
        else if (a > b) Console.WriteLine("Liczba " + a + " jest większa od liczby " + b);
        else Console.WriteLine("Liczba " + b + " jest większa od liczby " + a);
    }
}