using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_01;
/// <summary>
/// 商品情報を表すクラス
/// </summary>
class Item
{
    public int num { get; set; }
    public string name { get; set; }
    public int price { get; set; }

public void display(){
    Console.WriteLine("結果");
    Console.WriteLine("商品番号=" + num);
    Console.WriteLine("商品名=" + name);
    Console.WriteLine("単価=" + price);
}
    
}