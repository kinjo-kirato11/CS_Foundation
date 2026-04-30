namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("年を入力してください→");
        int year = int.Parse(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year}年は閏年です。");

        }
        else
        {
        Console.WriteLine($"{year}年は閏年ではありません。");

        }
    }
}
