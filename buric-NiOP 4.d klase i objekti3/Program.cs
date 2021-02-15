using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buric_NiOP_4.d_klase_i_objekti3
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaX x = new KlasaX();
            for (int i = 0; i < 100; i++) 
            x.arr[i] = i;

            x.index = 50;
            Console.WriteLine(x.arr[x.index]);

        }
    }
}