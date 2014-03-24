using System;

class ExchangeVars
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Values:\n   a=" + a + "\n   b=" + b);

        int cb = a;
        int ca = b;

        a = ca;
        b = cb;

        Console.WriteLine("Exchange Values of a and b\n   a=" + a + "\n   b=" + b);
    }
}