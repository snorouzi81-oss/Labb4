using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    internal class Circle
    {
        private int _radius;
        public int Radius { set; get; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public float GetArea(int radius)
        {
            return radius * radius * (float) Math.PI ;
        }
        public float GetCircumference(int radius)
        {
            return 2 * radius * (float)Math.PI;
        }
    }
}
