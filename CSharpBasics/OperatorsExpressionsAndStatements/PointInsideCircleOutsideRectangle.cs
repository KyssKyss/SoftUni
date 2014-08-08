using System;

namespace PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        //TODO: Ex.10 Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
        //and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
        //x	    y	    inside K & outside of R
        //1	    2	    yes
        //2.5	2	    no
        //0	    1	    no
        //2.5	1	    no
        //2 	0	    no
        //4	    0	    no
        //2.5	1.5	    no
        //2	    1.5	    yes
        //1	    2.5	    yes
        //-100	-100	no
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter X coordination: ");
                float pointX = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter Y coordination: ");
                float pointY = float.Parse(Console.ReadLine());
                float radius = 1.5f;
                int rectX = -1;
                int rectY = -1;
                int width = 6;
                int height = 2;
                int minX = Math.Min(rectX, (rectX + width));
                int maxX = Math.Max(rectX, (rectX + width));
                int minY = Math.Min(rectY, (rectY + height));
                int maxY = Math.Max(rectY, (rectY + height));
                bool isInside = false;
                //Use Pythagorean Theorem a2 + b2 = c2. The point is inside the circle when (x*x) + (y*y) ≤ 2*2
                if ((((pointX - 1) * (pointX - 1)) + ((pointY - 1) * (pointY - 1)) <= radius * radius) && !(((pointX <= maxX && pointX >= minX)) && (pointY <= maxY && pointY >= minY)))
                {
                    isInside = true;
                }
                Console.WriteLine(new string('-', Console.WindowWidth)); //print dash('-') through the whole console width
                Console.WriteLine("X\tY\tInside");
                Console.WriteLine(pointX + "\t" + pointY + "\t" + isInside);
                Console.WriteLine();
                Console.WriteLine(new string('-', Console.WindowWidth));
            }
        }
    }
}
