using System;

namespace MoonGravity
{
    class MoonGravity
    {
        //TODO: Ex.2 The gravitational field of the Moon is approximately 17% of that on the Earth.
        //Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:
        //weight	weight on the Moon
        //    86	14.62
        //    74.6	12.682
        //    53.7	9.129
        static void Main(string[] args)
        {
            //weight = 86
            float weight = 86;
            float moonWeight = weight * 0.17f;
            Console.WriteLine("The weight of a man on moon is: {0}",moonWeight);
            //weight = 74.6
            weight = 74.6f;
            moonWeight = weight * 0.17f; ;
            Console.WriteLine("The weight of a man on moon is: {0}", moonWeight);
            //weight = 53.7
            weight = 53.7f;
            moonWeight = weight * 0.17f; ;
            Console.WriteLine("The weight of a man on moon is: {0:F3}", moonWeight);
        }
    }
}
