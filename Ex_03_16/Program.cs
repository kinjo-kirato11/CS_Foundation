namespace Ex_03_16;

static class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        try
        {
            Console.Write("値1を入力してください->");
            int a = int.Parse(Console.ReadLine());
            Console.Write("値2を入力してください->");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("値1 / 値2 = " + calc.Div(a, b));
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InputParameterLessThanZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("必ず実行");

        }
        Console.WriteLine("プログラム正常終了");

    }
}
