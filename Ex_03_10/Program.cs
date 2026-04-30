using System.Security;
using Ex_03_10.Modules;

namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("DVDのタイトルを入力してください->");
        String dvdTitle = Console.ReadLine();
        Player dvd = new DVDPlayer(dvdTitle);
        dvd.Play();
        dvd.Stop();

        Console.Write("Blu-rayのタイトルを入力してください->");
        String blurayTitle = Console.ReadLine();
        Player bluray = new BlurayPlayer(blurayTitle);
        bluray.Play();
        bluray.Stop();
    }
}
