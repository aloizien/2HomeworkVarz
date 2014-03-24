using System;

class VarInHex
{
    static void Main()
    {
        short decValue = 254;
        string hexValue = decValue.ToString("X");

        Console.WriteLine(decValue);
        Console.WriteLine(hexValue);
    }
}