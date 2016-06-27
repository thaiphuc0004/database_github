using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Rectangle : Shape
    {
        public void Draw()
        {
            RectangleAdaptee recAdaptee = new RectangleAdaptee();
            recAdaptee.DrawRec();
            
        }
    }
}
