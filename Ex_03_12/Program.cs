using System.Security;
using Ex_03_12.Modules;

namespace Ex_03_12;

static class Program
{
    static void Main(string[] args)
    {

        Console.Write("DVDのタイトルを入力してください->");
        String dvdTitle = Console.ReadLine();
        Player dvd = new DVDPlayer(dvdTitle);
        dvd.UseMachine();

        Console.Write("Blu-rayのタイトルを入力してください->");
        String blurayTitle = Console.ReadLine();
        Player bluray = new BlurayPlayer(blurayTitle);
        bluray.UseMachine();
    }
}
