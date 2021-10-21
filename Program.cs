// マージの競合が発生して変更のどちらもが表示された例
using System;

namespace interpolated
{
    public class Vegetable
    {
        public Vegetable(string name) => Name = name;
        public string Name { get; }
        public override string ToString() => Name;
    }
    public class Program
    {
        public enum Unit { item, kilogram, gram, dozen };
        static void Main(string[] args)
        {
            var item = new Vegetable("eggplant");
            var date = DateTime.Now;
            var price = 1.99m;
            var unit = Unit.item;
            Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}.");
        }
    }
}
