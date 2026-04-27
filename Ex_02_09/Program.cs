namespace Ex_02_09;

static class Program
{
    static void Main(string[] args)
    {



        string[] eki = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };


        for (int i=0; i < eki.Length; i++)
        {
            System.Console.WriteLine($"{eki[i]}"); // 配列の要素を出力
        }
    }
}