using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison279
{
    public class Line
    {
        int pointX1, pointX2, pointY1, pointY2;
        public Line(int pointX1,int pointX2,int pointY1,int pointY2)
        {
            this.pointX1 = pointX1;
            pointY1 = pointY1;
            pointX2 = pointX2;
            this.pointX1 = pointX1;
        }
        public void Length()
        {
            double length = Math.Sqrt(Math.Pow((pointX2 - pointX1), 2) + Math.Pow((pointY2 - pointY1), 2));
            Console.WriteLine("The Length Of Line: "+length);
        }
    }
}
