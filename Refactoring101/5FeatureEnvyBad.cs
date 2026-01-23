using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.FeatureEnvyBad;

// 5
public class FeatureEnvy
{
    public void TestAdd()
    {
        // var point = Point.Add(new Point(2, 3), new Point(4, 5));
        //var point = new Point(2, 3).Add(new Point(4, 5));
        var point = new Point(2, 3) + new Point(4, 5);
    }
}

public class Point
{
    public double X { get; }
    public double Y { get; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    /*public static Point Add(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }*/

    /*public  Point Add(Point b)
    {
        return new Point(this.X + b.X, this.Y + b.Y);
    }*/
    public static Point operator + (Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }
}
