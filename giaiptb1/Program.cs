using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiptb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float a, x, b;
            Console.WriteLine("Giải phương trình bậc 1 có dạng: ax + b = 0");
            Console.Write("Mời nhập a :");
            a = float.Parse(Console.ReadLine());
            Console.Write("Mời nhập b :");
            b = float.Parse(Console.ReadLine());
            x = (-b / a);
            if (a != 0)
                Console.WriteLine("PT có nghiệm x = " + x);
            else if (a == 0 && b == 0)
                Console.WriteLine("PT vố số nghiệm");
            else
                Console.WriteLine("PT vô nghiệm");
            Console.ReadLine();
        }
    }
}
