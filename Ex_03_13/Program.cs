using System.Security.Cryptography;
using Ex_03_13;

namespace Ex_03_13;

static class Program
{
    static void Main(string[] args)
    {
        int r = 5;
        Circle circle = new Circle(r);

        Console.WriteLine($"{r}*{r}*{Circle.PI}={Circle.AreaCalculation(r)}");
        Console.WriteLine($"{r}*{r}*{Circle.PI}={circle.AreaCalculation()}");

        Circle.PI= 3;
        Console.WriteLine($"{r}*{r}*{Circle.PI}={Circle.AreaCalculation(r)}");
        Console.WriteLine($"{r}*{r}*{Circle.PI}={circle.AreaCalculation()}");

    }
}
