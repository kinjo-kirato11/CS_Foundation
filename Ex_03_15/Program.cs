namespace Ex_03_15;

static class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        try{
        Console.Write("値1を入力してください->");
        int a = int.Parse(Console.ReadLine());
        Console.Write("値2を入力してください->");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("値1 / 値2 = " + calc.Div(a,b));
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("例外:"+ ex.Message);
        }
    }
}
