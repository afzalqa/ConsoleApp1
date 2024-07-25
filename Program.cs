using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw,
            NotFinished
        }

        public static void Main()
        {
            Run("XXX OO. ...");
            Run("OXO XO. .XO");
            Run("OXO XOX OX.");
            Run("XOX OXO OXO");
            Run("... ... ...");
            Run("XXX OOO ...");
            Run("XOO XOO XX.");
            Run(".O. XO. XOX");
        }

        private static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        private static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];   
            for (int x = 0; x < field.Length; x++)
                for (var y = 0; y < field.Length; y++)
                    ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }
        public static GameResult GetGameResult(Mark[,] field)
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if(field[i, 0] == field[i, 1] && field[i, 1] == field[i, 2])
                {
                    if (field[i, 0] == Mark.Cross)
                        return GameResult.CrossWin;
                    if (field[i, 0] == Mark.Circle)
                        return GameResult.CircleWin;
                }
                // Check columns
                if (field[0,i] == field[1, i] && field[1, i] == field[2,i])
                {
                    if (field[0, i] == Mark.Cross)
                        return GameResult.CrossWin;
                    if (field[0, i] == Mark.Circle)
                        return GameResult.CircleWin;
                }
            }
            // Check diagonals
            if (field[0,0] == field[1,1] && field[1,1] == field[2,2])
            {
                if (field[0, 0] == Mark.Cross)
                    return GameResult.CrossWin;
                if (field[0, 0] == Mark.Circle)
                    return GameResult.CircleWin;
            }
            if (field[0,2] == field[1,1] && field[1,1] == field[2,0])
            {
                if (field[0, 2] == Mark.Cross)
                    return GameResult.CrossWin;
                if (field[0, 2] == Mark.Circle)
                    return GameResult.CircleWin;
            }
            // Check for draw or unfinished game
            bool isDraw = true;
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    if (field[x,y] == Mark.Empty)
                    {
                        isDraw = false;
                        break;
                    }
                    if (!isDraw)
                        break;
                }
            return isDraw ? GameResult.Draw : GameResult.NotFinished;
        }
    }
}
