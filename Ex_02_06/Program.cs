namespace Ex_02_06;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        var value1 = double.Parse(Console.ReadLine());//変数valueに入力された値を代入
        if (value1 % 4 == 0)
        {
            System.Console.WriteLine("4の倍数です。");
        }
        else
        {
            System.Console.WriteLine("4の倍数ではありません");
        }

    }
}