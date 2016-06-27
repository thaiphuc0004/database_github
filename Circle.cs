using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Circle : Shape
    {
        public void Draw()
        {
            CircleAdaptee cirAdaptee = new CircleAdaptee();
            cirAdaptee.DrawCir();
        }
    }
}
