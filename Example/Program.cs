namespace Example;

class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new("ユータ", 15);
        Console.WriteLine(warrior.name);
        Console.WriteLine(warrior.hp);



        Warrior warrior3 = new("三郎", 10);
        Console.WriteLine(warrior3.name);
        Console.WriteLine(warrior3.hp);

    }
}
