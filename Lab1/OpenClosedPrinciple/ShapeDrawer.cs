using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class ShapeDrawer
    {
        public void Draw(IEnumerable<object> shapes)
        {
            foreach(var shape in shapes)
            {
                if(shape is Circle)
                {
                    (shape as Circle).Draw();
                }
                else if(shape is Square)
                {
                    (shape as Square).Draw();
                }
            }
        }
    }
}
