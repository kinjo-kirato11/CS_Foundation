namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値1を入力してください->");
        var value1 = double.Parse(Console.ReadLine());//変数valueに入力された値を代入
        Console.Write("数値2を入力してください->");
        var value2 = double.Parse(Console.ReadLine());//変数valueに入力された値を代入
        Console.Write("数値3を入力してください->");
        var value3 = double.Parse(Console.ReadLine());//変数valueに入力された値を代入

        System.Console.WriteLine("入力結果");

        System.Console.WriteLine("数値1:" + value1);
        System.Console.WriteLine("数値2:" + value2);
        System.Console.WriteLine("数値3:" + value3);




    }
}
