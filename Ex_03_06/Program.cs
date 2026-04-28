using System.Globalization;

namespace Ex_03_06;


static class Program
{
    static void Main(string[] args)
    {


        Console.Write("商品番号を入力してください→");
        int pitemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください→");
        string pitemName = Console.ReadLine();
        Console.Write("単価を入力してください→");
        int pprice = int.Parse(Console.ReadLine());
        Item item = new Item(pitemNo, pitemName, pprice);

        Console.Write("新しい単価を入力してください→");
        pprice = int.Parse(Console.ReadLine());
        item.ChangePrice(pprice);

        // item.CalculateTaxAmount(price);

        item.Print();
        Console.Write("更に新しい単価を入力してください→");
        int price = int.Parse(Console.ReadLine());
        item.ChangePrice(price);

        item.Print();


    }
}
