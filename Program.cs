// マージの競合が発生して変更のどちらもが表示された例
using System;

namespace interpolated
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var name = "manaru更に変更";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
=======
            Object obj = new Object();
            Console.WriteLine(obj.ToString());
>>>>>>> 8002b16545384b7b4e79614de9b70f48bcc158a6
        }
    }
}
