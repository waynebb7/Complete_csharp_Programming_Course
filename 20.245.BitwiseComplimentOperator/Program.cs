using System.Diagnostics;

namespace _20._245.BitwiseComplimentOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int byteOfData = 13;    // 00001101
            System.Diagnostics.Debug.WriteLine(byteOfData);
            //System.Diagnostics.Debug.WriteLine(Convert.ToString(byteOfData, 2).Substring(24, 8)); //this does not work
            System.Diagnostics.Debug.WriteLine(~byteOfData);
            System.Diagnostics.Debug.WriteLine(Convert.ToString(~byteOfData, 2).Substring(24, 8));
            System.Diagnostics.Debug.WriteLine(Convert.ToString(~byteOfData, 2));

            // BITWISE LEFT SHIFT
            Debug.WriteLine("\nDemonstration of Bitwise Left-Shift-Operator (<<)");

            int a = 2;  // 00000010
            Debug.WriteLine("Initial Value (decimal): " + a);
            Debug.WriteLine("Type: " + a.GetType().ToString());
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a, 2));
            Debug.WriteLine("After Left-Shift-Operator (<<)(a << 1): " + (a << 1));    // 000000000100 or 4
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a << 1, 2));
            Debug.WriteLine("After Left-Shift-Operator (<<)(a << 2): " + (a << 2));    // 000000001000 or 8
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a << 2, 2));
            Debug.WriteLine("After Left-Shift-Operator (<<)(a << 3): " + (a << 3));    // 000000010000 or 16
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a << 3, 2));
            Debug.WriteLine("After Left-Shift-Operator (<<)(a << 4): " + (a << 4));    // 000000100000 or 32
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a << 4, 2));
            Debug.WriteLine("After Left-Shift-Operator (<<)(a << 5): " + (a << 5));    // 000001000000 or 64
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a << 5, 2));
            Debug.WriteLine("After Left-Shift-Operator (<<)(a << 6): " + (a << 6));    // 000010000000 or 128
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a << 6, 2));
            Debug.WriteLine("After Left-Shift-Operator (<<)(a << 7): " + (a << 7));    // 000100000000 or 256
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a << 7, 2));
            Debug.WriteLine("After Left-Shift-Operator (<<)(a << 8): " + (a << 8));    // 001000000000 or 512
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(a << 8, 2));

            // BITWISE RIGHT SHIFT
            Debug.WriteLine("\nDemonstration of Bitwise Right-Shift-Operator (>>)");

            int b = 128;  // 10000000
            Debug.WriteLine("Initial Value (decimal): " + b);
            Debug.WriteLine("Type: " + b.GetType().ToString());
            Debug.WriteLine("Initial Value  (binary): " + Convert.ToString(b, 2));
            Debug.WriteLine("After Left-Shift-Operator (>>)(b >> 1): " + (b >> 1));    // 01000000 or 64

            //BITWISE AND OPEATOR
            Debug.WriteLine("\nDemonstration of Bitwise AND Operator (&)");
            int c = 33;                 // 00100001
            int d = 129;                // 10000001
            Debug.WriteLine(c & d);     // 00000001 or 1

            //BITWISE OR OPEATOR
            Debug.WriteLine("\nDemonstration of Bitwise OR Operator (|)");
            int e = 33;                 // 00100001
            int f = 129;                // 10000001
            Debug.WriteLine(e | f);     // 10100001  or 161

            //BITWISE XOR OPEATOR
            Debug.WriteLine("\nDemonstration of Bitwise XOR Operator (^)");
            int g = 33;                 // 00100001
            int h = 129;                // 10000001
            Debug.WriteLine(g ^ h);     // 10100000  or 160

            //COMPOUND ASSIGNMENT LEFT-SHIFT
            Debug.WriteLine("\nDemonstration of Bitwise Compound Assignment Left Shift (<<=)");
            int i = 2;                  // 00000010 or 2
            i <<= 2; // left shift by 2 bits and assign to variable
            Debug.WriteLine(i);         // 00001000 or 8

            //COMPOUND ASSIGNMENT RIGHT-SHIFT
            Debug.WriteLine("\nDemonstration of Bitwise Compound Assignment Right Shift (>>=)");
            int j = 128;                  // 10000000 or 128
            j >>= 2; // right shift by 2 bits and assign to variable
            Debug.WriteLine(j);         // 00100000 or 32

            //COMPOUND ASSIGNMENT AND OPERATOR
            Debug.WriteLine("\nDemonstration of Bitwise Compound Assignment AND OPERATOR (&=)");
            int k = 33;                 // 00100001
            int l = 129;                // 10000001
            k &= l;
            Debug.WriteLine(k);         // 00000001 or 1

            //COMPOUND ASSIGNMENT OR OPERATOR
            Debug.WriteLine("\nDemonstration of Bitwise Compound Assignment OR OPERATOR (|=)");
            int m = 33;                 // 00100001
            int n = 129;                // 10000001
            m |= n;
            Debug.WriteLine(m);         // 10100001 or 161

            //COMPOUND ASSIGNMENT XOR OPERATOR
            Debug.WriteLine("\nDemonstration of Bitwise Compound Assignment XOR OPERATOR (^=)");
            int o = 33;                 // 00100001
            int p = 129;                // 10000001
            o ^= p;
            Debug.WriteLine(o);         // 10100000 or 160




        }
    }
}