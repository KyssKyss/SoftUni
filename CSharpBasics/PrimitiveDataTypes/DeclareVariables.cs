using System;

namespace DeclareVariables
{
    class DeclareVariables
    {
        //TODO: Ex.1 Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, 
        //int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. 
        //Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
        //Submit the source code of your Visual Studio project as part of your homework submission.
        public static void Main()
        {
            byte byteNumber = 97;
            sbyte sbyteNumber = -115;
            ushort ushortNumber = 52130;
            int intNumber = 4825932;
            short shortNumber = -10000;
            Console.WriteLine("byte - {0}",byteNumber);
            Console.WriteLine("sbyte - {0}",sbyteNumber);
            Console.WriteLine("ushort - {0}", ushortNumber);
            Console.WriteLine("sbyte - {0}", intNumber);
            Console.WriteLine("short - {0}", shortNumber);
        }
    }
}
