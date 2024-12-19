using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(byte.MinValue + "  " + byte.MaxValue);
            Console.WriteLine(sbyte.MinValue + "  " + sbyte.MaxValue);
            Console.WriteLine(short.MinValue + "  " + short.MaxValue);
            Console.WriteLine(ushort.MinValue + "  " + ushort.MaxValue);
            Console.WriteLine(int.MinValue + "  " + int.MaxValue);
            Console.WriteLine(uint.MinValue + "  " + uint.MaxValue);
            Console.WriteLine(long.MinValue + "  " + long.MaxValue);
            Console.WriteLine(ulong.MinValue + "  " + ulong.MaxValue);

            // Explicit TC - Parse()
            //string x = "300";
            //int y = int.Parse(x);
            //Console.WriteLine(x + "  " + y);
        }
    }
}
