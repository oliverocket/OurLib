using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ourConsole
{
    using OurLib;
    class MainEntry
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum.Add(1, 3));
            Console.WriteLine(Sum.Add(0.45f, 4.56f));
            Console.ReadKey(true);
        }
    }
}
