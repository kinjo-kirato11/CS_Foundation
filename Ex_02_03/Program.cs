namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        var value = double.Parse(Console.ReadLine());//変数valueに入力された値を代入
        Console.WriteLine(value); //入力された値を表示
        int a = 5;
        value += a;

        System.Console.WriteLine("5を加算した結果は" + value+"です");

        value = value-a-a;
        System.Console.WriteLine("5を減算した結果は" + value+"です");


    }
}
