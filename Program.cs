// マージの競合が発生して変更のどちらもが表示された例
using System;

namespace interpolated
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Object();
            Console.WriteLine(obj.ToString());
        }
    }
}
