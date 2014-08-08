using System;

namespace RectangesCalculation
{
    class RectangesCalculation
    {
        //TODO: Ex.4 Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
        //width	height	perimeter	area
        //    3	    4	        14	12
        //    2.5	3	        11	7.5
        //    5	    5	        20	25
        static void Main()
        {
            float width = 0;
            int height = 0;
            float perimeter;
            float area;
            //width	height	perimeter	area
            //    3	    4	       14	   12
            width = 3f;
            height = 4;
            perimeter = 2 * width + 2 * height;
            area = (float)width * height;
            Console.WriteLine("The perimeter is: {0} and the area is: {1}",perimeter,area);
            //width	height	perimeter	area
            //    2.5	3	        11	7.5
            width = 2.5f;
            height = 3;
            perimeter = 2 * width + 2 * height;
            area = (float)width * height;
            Console.WriteLine("The perimeter is: {0} and the area is: {1}", perimeter, area);
            //width	height	perimeter	area
            //    5	    5	        20	25
            width = 5f;
            height = 5;
            perimeter = 2 * width + 2 * height;
            area = (float)width * height;
            Console.WriteLine("The perimeter is: {0} and the area is: {1}", perimeter, area);
        }
    }
}
