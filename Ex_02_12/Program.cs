namespace Ex_02_12;

static class Program
{
    static int Mul3(int a)
    {
        return a * 3; // 引数aを３倍にして返す
    }
    static void Main(string[] args)
    {
        Console.Write("値を入力してください: ");
        int num1 = int.Parse(Console.ReadLine());
        int result =Mul3(num1);
        Console.WriteLine(result);
    }
}
