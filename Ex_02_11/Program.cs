namespace Ex_02_10;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("駅名を入力してください");
        string str = Console.ReadLine();
        string[] ekis = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };

        foreach (string eki in ekis)
        {
            if (str == eki)
            {
                continue;
            }
            Console.WriteLine(eki);
        }
    }
}