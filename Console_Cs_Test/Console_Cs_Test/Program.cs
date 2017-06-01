using System;
using System.Collections.Generic;
using System.Linq;

class Program
{    
    public static void Main()
    {
        char[] S = Console.ReadLine().ToArray();
        char[] R = new Char[S.Length];
        for (int i = 0;i < S.Length; ++i)
        {
            R[i] = ToAscii(S[i],i + 1);
        }
        Console.WriteLine($"{string.Join("",R)}");
    }    

    private static char ToAscii(char c,int n)
    {
        int code = (int)c + 26 - (n % 26);
        if (code > 90) { code -= 26; }
        return (char)(code);
    }
}