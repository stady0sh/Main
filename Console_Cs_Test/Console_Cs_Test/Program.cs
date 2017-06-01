﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    /// <summary>
    /// C#の幅優先探索(Breadth First Search)の例
    /// URL : http://algoful.com/Archive/Algorithm/BFS
    /// </summary>
    static void Main()
    {
        var maze = CreateMaze();
        var bfs = new MazeBfs(maze);
        bfs.Search();
        bfs.DebugPrint(maze);

    }

    // 15*15 の動作確認用迷路の配列を作成します。
    public static int[,] CreateMaze()
    {
        return new int[15, 15] {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,0,0,1,0,0,0,0,0,0,0,0,0,1},
                {1,1,1,0,1,1,1,0,1,1,1,0,1,0,1},
                {1,0,1,0,0,0,1,0,0,0,1,0,1,0,1},
                {1,0,1,1,1,0,1,1,1,0,1,0,1,1,1},
                {1,0,1,0,0,0,0,0,0,0,1,0,0,0,1},
                {1,0,1,0,1,1,1,1,1,1,1,1,1,0,1},
                {1,0,0,0,0,0,0,0,1,0,1,0,0,0,1},
                {1,1,1,1,1,0,1,0,1,0,1,0,1,1,1},
                {1,0,0,0,1,0,1,0,0,0,1,0,0,0,1},
                {1,0,1,0,1,0,1,1,1,0,1,1,1,1,1},
                {1,0,1,0,1,0,0,0,1,0,1,0,0,0,1},
                {1,0,1,0,1,1,1,0,1,0,1,0,1,0,1},
                {1,0,1,0,0,0,0,0,1,0,0,0,1,0,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
            };
    }
    
}

public class MazeBfs
{
    private int[,] Maze;            // 迷路
    private int[] VisitedArray;     // 訪問済み配列
    private Cell Start;             // 迷路スタート
    private Cell Goal;              // 迷路ゴール

    // 迷路の横幅
    private int MazeWidth
    {
        get { return this.Maze.GetLength(0); }
    }

    // 迷路の高さ
    private int MazeHeight
    {
        get { return this.Maze.GetLength(1); }
    }

    // コンストラクタ
    public MazeBfs(int[,] maze)
    {
        this.Maze = maze;
        this.VisitedArray = new int[MazeWidth * MazeHeight];
        this.Start = new Cell(1, 1);
        this.Goal = new Cell(MazeWidth - 2, MazeHeight - 2);
    }

    // 探索処理
    public void Search()
    {
        var isGoaled = false;
        var queue = new Queue<Cell>();
        queue.Enqueue(Start);

        // 訪問済み配列を -1 で初期化
        VisitedArray = Enumerable.Repeat(-1, VisitedArray.Length).ToArray();
        VisitedArray[ToIndex(Start)] = ToIndex(Start);

        // 探索持ちのセルがなくなるまで続ける
        while (queue.Count > 0 && !isGoaled)
        {
            // 探索対象のセルを取り出す
            var target = queue.Dequeue();

            // 対象のセルから上下左右のセルを探索する
            foreach (Direction dir in Enum.GetValues(typeof(Direction)))
            {
                // 次の探索セルを作成する
                var nextCell = new Cell(target.X, target.Y);
                switch (dir)
                {
                    case Direction.Up:
                        nextCell.Y -= 1;
                        break;
                    case Direction.Right:
                        nextCell.X += 1;
                        break;
                    case Direction.Down:
                        nextCell.Y += 1;
                        break;
                    case Direction.Left:
                        nextCell.X -= 1;
                        break;  
                }

                // 探索候補セルが範囲内
                if (nextCell.X >= 0 && nextCell.Y >= 0 && nextCell.X < MazeWidth && nextCell.Y < MazeHeight)
                {
                    // 未探索の場合かつ通路の場合のみキューにつめると同時に探索済情報設定
                    if (VisitedArray[ToIndex(nextCell)] < 0
                        && Maze[nextCell.X,nextCell.Y] == Path)
                    {
                        // 探索済み情報
                        SetVisited(target, nextCell);
                        if (nextCell.X == Goal.X && nextCell.Y == Goal.Y)
                        {
                            // 探索候補がゴールの場合すぐに抜けるために探索候補を削除して抜ける
                            // Console.log('ゴールが見つかりました。おめでとう．．．');
                            queue.Clear();
                            queue.Enqueue(nextCell);
                            isGoaled = true;
                            break;
                        }
                        else
                        {
                            // キューに詰める
                            queue.Enqueue(nextCell);
                        }
                    }
                }
            }
        }
        // 探索結果を配列に設定
        if (isGoaled)
        {
            SetRoute();
        }
    }

    // ゴールへのルートを2次元配列に設定
    public void SetRoute()
    {
        // 訪問済みの配列からゴールまでのルートを設定する
        var startIndex = ToIndex(Start);
        var goalIndex = ToIndex(Goal);
        var beforeIndex = VisitedArray[goalIndex];
        var route = new List<int>();

        while (beforeIndex >= 0 && beforeIndex != startIndex)
        {
            // ゴールからスタートへのルートをたどる
            route.Add(beforeIndex);
            beforeIndex = VisitedArray[beforeIndex];
        }

        // ゴールへのルートを設定
        foreach (var index in route)
        {
            var cell = ToCell(index);
            Maze[cell.X, cell.Y] = Route;
        }
    }

    // 訪問済みデータの設定を行う
    private void SetVisited(Cell fromCell,Cell toCell)
    {
        var fromIndex = ToIndex(fromCell);
        var toIndex = ToIndex(toCell);
        VisitedArray[toIndex] = fromIndex;
    }

    // Cellを1次元配列のインデックスに変換
    private int ToIndex(Cell cell)
    {
        return cell.X + MazeWidth * cell.Y;
    }

    // 1次元配列のインデックスをセルに変換
    private Cell ToCell(int index)
    {
        return new Cell(index % MazeWidth, index / MazeWidth);
    }
    
    // 通路・壁情報
    const int Path = 0;
    const int Wall = 1;
    const int Route = 99;

    // セル情報
    private struct Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Cell(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    // 方向
    private enum Direction
    {
        Up = 0,
        Right = 1,
        Down = 2,
        Left = 3
    }

    // デバッグ用処理
    public void DebugPrint(int[,] maze)
    {
        var text = string.Empty;
        Console.WriteLine($"Width: {maze.GetLength(0)}");
        Console.WriteLine($"Height: {maze.GetLength(1)}");
        for (int y = 0; y < maze.GetLength(1); y++)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                if (x == Start.X && y == Start.Y)
                {
                    text += "S ";
                }
                else if (x == Goal.X && y == Goal.Y)
                {
                    text += " G";
                }
                else if (maze[x, y] == Path)
                {
                    text += "  ";
                }
                else if (maze[x, y] == Wall)
                {
                    text += "##";
                }
                else if (maze[x, y] == Route)
                {
                    text += "..";
                }
            }
            text += "\r\n";
        }
        Console.WriteLine(text);
        Console.WriteLine("キーを入力すると終了");
        Console.ReadLine();
    }


}