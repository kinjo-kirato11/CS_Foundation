using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_04;
/// <summary>
/// 商品情報を表すクラス
/// </summary>
class Item
{
    private int num;
    private string name;
    private int price;
    public double salesTaxRate = 0.10;

    public int sprice;

    public void SetPrice(int num, string name, int price)
    {
        this.num = num;
        this.name = name;
        this.price = price;
    }
    public void Print()
    {
        Console.WriteLine("結果");
        Console.WriteLine("商品番号=" + num);
        Console.WriteLine("商品名=" + name);
        Console.WriteLine("単価=" + price);
        Console.Write("税込み金額=" + sprice);


    }

    public void ChangePrice(int pprice)
    {
        this.price = pprice;

    }

    public int CalculateTaxAmount(int sprice)
    {
        this.sprice = (int)(price * (salesTaxRate + 1));

return 0;

    }

}