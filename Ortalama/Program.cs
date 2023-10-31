// See https://aka.ms/new-console-template for more information


public class FibonacciCalculator
{
    public int CalculateFibonacci(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            int a = 0;
            int b = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }
    }
}

public class AverageCalculator
{
    public double CalculateFibonacciAverage(int depth)
    {
        FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
        double total = 0;

        for (int i = 0; i < depth; i++)
        {
            total += fibonacciCalculator.CalculateFibonacci(i);
        }

        if (depth == 0)
        {
            return 0;
        }
        else
        {
            return total / depth;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Fibonacci derinliğini girin: ");
        int depth = int.Parse(Console.ReadLine());

        AverageCalculator averageCalculator = new AverageCalculator();
        double average = averageCalculator.CalculateFibonacciAverage(depth);

        Console.WriteLine($"Fibonacci serisinin derinliği {depth} için ortalama: {average}");
    }
}

