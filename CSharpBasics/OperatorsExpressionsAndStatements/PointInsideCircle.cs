using System;

namespace PointInsideCircle
{
    class PointInsideCircle
    {
        //TODO: Ex.7 Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
        //x	y	inside
        //0	1	true
        //-2	0	true
        //-1	2	false
        //1.5	-1	true
        //-1.5	-1.5	false
        //100	-30	false
        //0	0	true
        //0.2	-0.8	true
        //0.9	-1.93	false
        //1	1.655	true
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Write a given point X coordination:");
                float pointSideX = float.Parse(Console.ReadLine());
                Console.WriteLine("Write a given point Y coordination:");
                float pointSideY = float.Parse(Console.ReadLine());
                int radius = 2;
                bool isInside = false;
                //Use Pythagorean Theorem a2 + b2 = c2. The point is inside the circle when (x*x) + (y*y) ≤ 2*2
                if ((pointSideX * pointSideX) + (pointSideY * pointSideY) <= (radius * radius))
                {
                    isInside = true;
                }
                Console.WriteLine(new string('-', Console.WindowWidth)); //print dash('-') through the whole console width
                Console.WriteLine("X\tY\tInside");
                Console.WriteLine(pointSideX + "\t" + pointSideY + "\t" + isInside);
                Console.WriteLine();
                Console.WriteLine(new string('-', Console.WindowWidth));
            }
        }
    }
}
