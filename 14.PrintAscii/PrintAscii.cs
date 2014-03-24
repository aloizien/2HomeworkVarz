using System;

class PrintAscii
{
    static void Main()
    {
        
        for(char i='\u0020'; i<=256; i++)
        {
            Console.Write(i);
        }
    }
}