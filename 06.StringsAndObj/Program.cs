using System;

class StringsAndObj
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World";
        object obj = helloString+" "+worldString;

        string hwstring = (string)obj;
        
        Console.WriteLine(obj);

        Console.WriteLine(hwstring);

    }
}