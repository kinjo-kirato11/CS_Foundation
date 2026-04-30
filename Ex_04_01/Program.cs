using Ex_04_01.Ex_04_01_Lib;
namespace Ex_04_01;



static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();
        Console.Write("商品番号を入力してください→");
        int ItemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください→");
        string itemName = Console.ReadLine();
        Console.Write("単価を入力してください→");
        int Price = int.Parse(Console.ReadLine());

        Console.WriteLine("結果");
        Console.WriteLine("商品番号=" + ItemNo);
        Console.WriteLine("商品名=" + itemName);
        Console.WriteLine("単価=" + Price);
    }
}
