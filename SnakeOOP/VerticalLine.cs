using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class VerticalLine : figure
    {
     
        public VerticalLine(int yUp, int yDown, int x, char symb)
        {
            pointList = new List<Point>();
            for(int i = yUp; i <= yDown; i++)
            {
                Point p = new Point(x, i, symb);
                pointList.Add(p);
            }
        }

    }

}
