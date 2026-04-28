using Ex_03_07.Models;
namespace Ex_03_07;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("商品番号を入力してください→");
        int ItemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください→");
        string ItemName = Console.ReadLine();
        Console.Write("単価を入力してください→");
        int Price = int.Parse(Console.ReadLine());
        Item item = new Item(ItemNo, ItemName, Price);
        // item.CalculateTaxAmount(price);

        item.Print();
    }
}
