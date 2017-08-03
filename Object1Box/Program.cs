using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object1Box
{
    class Program
    {

        public static void Main(string[] args)
        {

            Box b = new Box();
            b.x = 2;
            b.y = 3;
            b.z = 4;
            b.c = 10;
            Console.WriteLine("\nThe volume of the box is: "+b.Volume());
            Console.WriteLine("\nThe surface area of the box is: "+b.SurfaceArea());
            Console.WriteLine("\nThe cost of the box is: "+b.Cost());
            Console.ReadLine();
        }
        
        
    }
}
