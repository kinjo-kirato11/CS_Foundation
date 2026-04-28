using System.Globalization;

namespace Ex_03_04;


static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();

        Console.Write("商品番号を入力してください→");
        int num = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください→");
        string name = Console.ReadLine();
        Console.Write("単価を入力してください→");
        int price = int.Parse(Console.ReadLine());

        item.SetPrice(num,name,price);

        item.CalculateTaxAmount(price);

        item.Print();

    }
}
