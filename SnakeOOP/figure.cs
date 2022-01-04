using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class figure
    {
        protected List<Point> pointList;

        public void Draw()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}
