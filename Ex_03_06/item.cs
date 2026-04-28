using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_06;
/// <summary>
/// 商品情報を表すクラス
/// </summary>
class Item
{
    private int pitemNo;
    private string pitemName;
    private int pprice;
    //public double salesTaxRate = 0.10;

    //public int sprice;
public Item()
    {
        
    }
    public Item(int pitemNo, string pitemName, int pprice)
    {
        this.pitemNo = pitemNo;
        this.pitemName = pitemName;
        this.pprice = pprice;
    }

    /*public void SetPrice(int num, string name, int price)
    {
        this.num = num;
        this.name = name;
        this.price = price;
    }
    */
    public void Print()
    {
        Console.WriteLine("結果");
        Console.WriteLine("商品番号=" + pitemNo);
        Console.WriteLine("商品名=" + pitemName);
        Console.WriteLine("単価=" + pprice);
        //Console.Write("税込み金額=" + sprice);


    }

    public void ChangePrice(int pprice)
     {
         this.pprice = pprice;

     }
 public void ChangePrice(string pprice)
    {
                 this.pprice = int.Parse(pprice);

    }
    /*public int CalculateTaxAmount(int sprice)
    {
        this.sprice = (int)(price * (salesTaxRate + 1));

        return 0;

    }
    */

}