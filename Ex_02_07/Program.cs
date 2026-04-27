namespace Ex_02_06;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        var value1 = double.Parse(Console.ReadLine());//変数valueに入力された値を代入
        if (value1  > 0)
        {
            System.Console.WriteLine("正の値です。");
        }
        else if(value1 < 0)
        {
            System.Console.WriteLine("負の値です。");
        }
        else
        {
            System.Console.WriteLine("０です。");
        }

    }
}