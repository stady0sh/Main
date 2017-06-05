using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public void Proc()
    {
        Reader.IsDebug = false;
        string inpt = Reader.ReadLine();
        StringBuilder ans = new StringBuilder();
        for (int i = 0; i < inpt.Length; i++)
        {
            char c = (char)(inpt[i] - ((i + 1) % ('Z' - 'A' + 1)));
            if (c < 'A')
            {
                c = (char)(c - 'A' + 'Z' + 1);
            }
            ans.Append(c);
        }
        Console.WriteLine(ans.ToString());
    }

    public static void Main()
    {
        Program prg = new Program();
        prg.Proc();
    }
}

class Reader
{
    public static bool IsDebug = true;

    private static System.IO.StringReader sr;

    public static string ReadLine()
    {
        if (IsDebug)
        {
            if (sr == null)
            {
                sr = new System.IO.StringReader(initStr.Trim());
            }
            return sr.ReadLine();
        }
        else {
            return Console.ReadLine();
        }
    }

    public static int[] GetInt(char delimiter = ' ')
    {
        string[] inpt = ReadLine().Split(delimiter);
        int[] ret = new int[inpt.Length];
        for (int i = 0; i < inpt.Length; i++)
        {
            ret[i] = int.Parse(inpt[i]);
        }
        return ret;
    }

    private static string initStr = @"

BCD

";
}

