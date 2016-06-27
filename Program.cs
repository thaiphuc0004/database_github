using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle cir = new Circle();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(rec);
            shapes.Add(cir);

            foreach (Shape s in shapes)
            {
                s.Draw();
            }

            Console.ReadLine();
        }
    }
}
