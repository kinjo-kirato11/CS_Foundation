
using Ex_03_09.Modules;
namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {

        Console.Write("口座番号を入力してください→");
        String AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください→");
        String AccountName = Console.ReadLine();
        Console.Write("残高を入力してください→");
        int Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください→");
        int Point = int.Parse(Console.ReadLine());

        NetAccount account = new NetAccount(AccountNo, AccountName, Balance, Point);

        account.Print();
        Console.WriteLine(account.ToString());
    }
}
