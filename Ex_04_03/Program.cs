 using Ex_04_03.Modules;
 using System.Collections.Generic;

namespace Ex_04_03;

static class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            Console.Write("社員番号を入力してください->");
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }
            int id = int.Parse(input);
            Console.Write("社員名を入力してください->");
            string name = Console.ReadLine();

            Console.Write("住所を入力してください->");
            string address = Console.ReadLine();

            employees.Add(new Employee(id,name,address));

        }
        foreach(Employee emp in employees)
        {
                    Console.WriteLine(emp);

        }
    }
}
