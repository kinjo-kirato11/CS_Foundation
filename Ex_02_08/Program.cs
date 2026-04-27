namespace Ex_02_06;

static class Program
{
    static void Main(string[] args)
    {



        string[] eki = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };

        int i = 0;
        while (i < eki.Length)
        {
            System.Console.WriteLine(eki[i]); // 配列の要素を出力
            i++; // インデックスをインクリメント
        }
    }
}