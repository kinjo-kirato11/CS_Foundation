namespace Ex_02_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        var value1 = double.Parse(Console.ReadLine());//変数valueに入力された値を代入
        if (value1 % 2 == 0)
        {
            value1 = value1*10;
        }
        System.Console.WriteLine("結果:" + value1);




    }
}
