using System;

class ComparinFloats
{
    static void Main()
    {
        double a1 = 5.3;
        double a2 = 6.1;

        double b1 = 5.00000001;
        double b2 = 5.00000003;

        double c1 = 5.00000005;
        double c2 = 5.00000001;

        double d1 = -0.0000007;
        double d2 = 0.00000007;

        double e1 = -4.999999;
        double e2 = -4.999998;

        double f1 = -4.999999;
        double f2 = -4.999998;

        bool a = Math.Abs(a1 - a2) < 0.000001;
        Console.WriteLine(a);

        bool b = Math.Abs(b1 - b2) < 0.000001;
        Console.WriteLine(b);

        bool c = Math.Abs(c1 - c2) < 0.000001;
        Console.WriteLine(c);

        bool d = Math.Abs(d1 - d2) < 0.000001;
        Console.WriteLine(d);

        bool e = Math.Abs(e1 - e2) < 0.000001;
        Console.WriteLine(e);

        bool f = Math.Abs(f1 - f2) < 0.000001;
        Console.WriteLine(f);

    }
}