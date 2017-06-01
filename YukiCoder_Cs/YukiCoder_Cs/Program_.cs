using System;
using System.Collections.Generic;
using System.Linq;

public class Program_
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var q = new Queue<Square>();
        q.Enqueue(new Square(1, 1));
        var already = new bool[N];
        if (N == 1)
        {
            Console.WriteLine(1);
            return;
        }
        while (q.Any())
        {
            var pop = q.Dequeue();
            int num = pop.Num;
            int mov = 0;
            for (int i = num; i > 0; i >>= 1)
            {
                mov += i & 1;
            }
            int go = num + mov;
            if (go < N && !already[go - 1])
            {
                already[go - 1] = true;
                q.Enqueue(new Square(go, pop.Count + 1));
            }
            if (go == N)
            {
                Console.WriteLine(pop.Count + 1);
                return;
            }
            int back = num - mov;
            if (back > 0 && !already[back - 1])
            {
                already[back - 1] = true;
                q.Enqueue(new Square(back, pop.Count + 1));
            }
        }
        Console.WriteLine(-1);
    }
}

public class Square
{
    public Square(int num, int count)
    {
        this.Num = num;
        this.Count = count;
    }

    public int Num;
    public int Count;
}