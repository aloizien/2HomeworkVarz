using System;

class QuotesInStrings
{
    static void Main()
    {
        string a1 = @"The ""use"" of quotations causes difficulties";
        string a2 = "The \"use\" of quotations causes no more difficulties";

        Console.WriteLine(a1);
        Console.WriteLine(a2);

    }
}