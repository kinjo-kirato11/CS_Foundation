using Ex_04_04.Modules;
namespace Ex_04_04;

static class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Item> items = new Dictionary<int, Item>()
        {
            {101, new Item(101,"水性ボールペン(黒)",150)},
            {102, new Item(102,"油性ボールペン(黒)",100)},
            {103, new Item(103,"鉛筆(黒)",60)},
            {104, new Item(104,"鉛筆(赤)",80)}


        };
        Console.Write("商品番号を入力してください->");
        int inputID = int.Parse(Console.ReadLine());

        if (items.ContainsKey(inputID))
        {
            Console.WriteLine(items[inputID]);
        }
        else
        {
                        Console.WriteLine("該当する商品がありません。");

        }
    }
}
