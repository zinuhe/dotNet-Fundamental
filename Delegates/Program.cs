// See https://aka.ms/new-console-template for more information

namespace Delegates;

public class Program
{
    // declare delegate
    delegate int Calculator (int x, int y);

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Delegates");

        // Approach 1
        // Instanciate the delegate
        Calculator sum1 = new Calculator (Add);
        // Caling a method using Delegate
        Console.WriteLine("Delegate 1: " + sum1(0, 1));


        // Approach 2
        Calculator sum2 = Add;
        Console.WriteLine("Delegate 2: " + sum2(1, 1));


        // Approach 3 - Anonymous Delegates
        Calculator sum3 = delegate (int e, int f)
        {
            return e + f;
        };
        Console.WriteLine("Delegate 3: " + sum3(2, 1));


        // Approach 4
        Calculator sum4 = (g, h) => g + h;
        Console.WriteLine("Delegate 3: " + sum4(2, 2));
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Mul(int c, int d)
    {
        return c * d;
    }
}
