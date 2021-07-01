using System;

namespace _999._Available_Captures_for_Rook
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board1 = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'R', '.', '.', '.', 'p' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            Console.WriteLine(NumRookCaptures1(board1));
            Console.WriteLine(NumRookCaptures2(board1));

            char[][] board2 = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'B', 'R', 'B', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            Console.WriteLine(NumRookCaptures1(board2));
            Console.WriteLine(NumRookCaptures2(board2));

            char[][] board3 = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { 'p', 'p', '.', 'R', '.', 'p', 'B', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'B', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            Console.WriteLine(NumRookCaptures1(board3));
            Console.WriteLine(NumRookCaptures2(board3));

            char[][] board4 = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'R', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            Console.WriteLine(NumRookCaptures1(board4));
            Console.WriteLine(NumRookCaptures2(board2));

            char[][] board5 = new char[][]
            {
                new char[] { 'R', '.', 'p', '.', 'p', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { 'p', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { 'p', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            Console.WriteLine(NumRookCaptures1(board5));
            Console.WriteLine(NumRookCaptures2(board5));
        }

        public static int NumRookCaptures1(char[][] board)
        {
            int availableCaptures = 0;
            int[] rookPosition = FindRook(board);
            int rowIndex = rookPosition[0];

            while (rowIndex > 0)
            {
                rowIndex--;

                if (board[rowIndex][rookPosition[1]] == 'p')
                {
                    availableCaptures++;
                    break;
                }
                else if (board[rowIndex][rookPosition[1]] == 'B')
                {
                    break;
                }
            }

            rowIndex = rookPosition[0];

            while (rowIndex < board.Length - 1)
            {
                rowIndex++;

                if (board[rowIndex][rookPosition[1]] == 'p')
                {
                    availableCaptures++;
                    break;
                }
                else if (board[rowIndex][rookPosition[1]] == 'B')
                {
                    break;
                }
            }

            int colIndex = rookPosition[1];

            while (colIndex > 0)
            {
                colIndex--;

                if (board[rookPosition[0]][colIndex] == 'p')
                {
                    availableCaptures++;
                    break;
                }
                else if (board[rookPosition[0]][colIndex] == 'B')
                {
                    break;
                }
            }

            colIndex = rookPosition[1];

            while (colIndex < board.Length - 1)
            {
                colIndex++;

                if (board[rookPosition[0]][colIndex] == 'p')
                {
                    availableCaptures++;
                    break;
                }
                else if (board[rookPosition[0]][colIndex] == 'B')
                {
                    break;
                }
            }

            return availableCaptures;
        }

        private static int[] FindRook(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == 'R')
                    {
                        return new int[] { row, col };
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        public static int NumRookCaptures2(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == 'R')
                    {
                        return AvailableForCapture(board, row, col, 1, 0) + AvailableForCapture(board, row, col, -1, 0) + AvailableForCapture(board, row, col, 0, 1) + AvailableForCapture(board, row, col, 0, -1);
                    }
                }
            }

            return 0;
        }

        private static int AvailableForCapture(char[][] board, int row, int col, int deltaRow, int deltaCol)
        {
            while (row >= 0 && row <= board.Length - 1 && col >= 0 && col <= board.Length - 1)
            {
                if (board[row][col] == 'p')
                {
                    return 1;
                }
                else if (board[row][col] == 'B')
                {
                    break;
                }

                row += deltaRow;
                col += deltaCol;
            }

            return 0;
        }
    }
}
