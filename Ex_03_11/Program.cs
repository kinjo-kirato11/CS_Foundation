using System.ComponentModel.DataAnnotations;
using Ex_03_11.Modules;

namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        IUSB fiash= new FiashMemory();
        fiash.SendData();
        fiash.ReciveData();

        IUSB Mouse = new Mouse();
        Mouse.SendData();

        IUSB Display  = new Display();
        Display.ReciveData();
    }
}
