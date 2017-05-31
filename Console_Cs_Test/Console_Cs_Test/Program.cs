using System;
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






                    }



                }




            }





        }




    }


    // 訪問済みデータの設定を行う
    private void SetVisited(Cell formCell,Cell toCell)
    {

    }

    // Cellを1次元配列のインデックスに変換
    private int ToIndex(Cell cell)
    {
        return cell.X + MazeWidth * cell.Y;
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



}