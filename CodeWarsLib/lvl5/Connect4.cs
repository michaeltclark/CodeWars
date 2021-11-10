using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsLib.lvl5
{
    // Class called Connect4
    /// <summary>
    /// https://www.codewars.com/kata/586c0909c1923fdb89002031
    /// </summary>
    public static class Connect4
    {
        // The columns are numbered 0-6 left to right [7]. The rows are 0-5 [6]
        // 0    1   2   3   4   5   6
        // 1
        // 2
        // 3
        // 4
        // 5
        private static int[,] gameBoard = new int[6, 7];

        private static int currentPlayer = 1;

        private static int matchCount = 0;

        private static bool GameIsWon = false;


        // has a method called play which takes one argument for the column where the player is going to place their disc.
        public static string Play(int col)
        {
            // If the game has been won by a player, any following moves should return ”Game has finished!”.
            if (GameIsWon) return "Game has finished!";

            // If a player attempts to place a disc in a column that is full then you should return ”Column full!” and the next move must be taken by the same player.
            if (!TryAddDisc(col, currentPlayer)) return "Column full!";

            // Check if the current player has won the game.
            GameIsWon = CheckForWin(currentPlayer);

            // If a player successfully has 4 discs horizontally, vertically or diagonally then you should return "Player n wins!” where n is the current player either 1 or 2.
            if (GameIsWon) return $"Player {currentPlayer} wins!";

            // Player 1 starts the game every time and alternates with player 2.
            currentPlayer = currentPlayer == 1 ? 2 : 1;

            // Any other move should return ”Player n has a turn” where n is the current player either 1 or 2.
            return $"Player {currentPlayer} has a turn";
        }

        public static void Reset()
        {
            gameBoard = new int[6, 7];

            currentPlayer = 1;

            matchCount = 0;

            GameIsWon = false;
        }

        public static bool CheckForWin(int currentPlayer)
        {
            for (int i = 0; i < 5; i++)
            {
                matchCount = 0;

                // Vertical j + 1
                for (int j = 0; j < 6; j++)
                {
                    if (gameBoard[i, j] == currentPlayer)
                    {
                        matchCount++;
                    }
                    else
                    {
                        matchCount = 0;
                    }

                    if (matchCount == 4) return true;
                }
            }

            // Horizontal i + 1 
            for (int j = 0; j < 6; j++)
            {
                matchCount = 0;

                for (int i = 0; i < 5; i++)
                {
                    if (gameBoard[i, j] == currentPlayer)
                    {
                        matchCount++;
                    }
                    else
                    {
                        matchCount = 0;
                    }

                    if (matchCount == 4) return true;
                }
            }

            matchCount = 0;

            // 0 - 0 - 0
            // 0 - 1 - 1
            // 0 - 2 - 2
            //...
            // 1 - 0 - 1 // 1 - 1 - 1
            // 1 - 1 - 2 // 1 - 2 - 2
            //...
            // 1 - 5 - 6 // 1 - 5 - 5 
            //Diagonal i +1 & j + 1
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (gameBoard[i, j] == currentPlayer)
                    {
                        matchCount = 1;
                        if (SearchPDiagonal(i, j, currentPlayer)) return true;
                        matchCount = 1;
                        if (SearchMDiagonal(i, j, currentPlayer)) return true;
                    }
                    else
                    {
                        matchCount = 0;
                    }
                }
            }

            // Current player did not win
            return false;
        }

        private static bool SearchPDiagonal(int i, int j, int currentPlayer)
        {
            if (i+1 > 5) return false;
            if (j +1 > 6) return false;
            if (gameBoard[i + 1, j + 1] == currentPlayer)
            {
                matchCount++;
                if (matchCount == 4) return true;
                SearchPDiagonal(i + 1, j + 1, currentPlayer);
            }

            return false;
        }

        private static bool SearchMDiagonal(int i, int j, int currentPlayer)
        {
            if (i-1 < 0) return false;
            if (j-1 < 0) return false;
            if (gameBoard[i - 1, j + 1] == currentPlayer)
            {
                matchCount++;
                if (matchCount == 4) return true;
                SearchMDiagonal(i - 1, j + 1, currentPlayer);
            }

            return false;
        }


        public static bool TryAddDisc(int col, int player)
        {
            for (int i = 0; i < 5; i++)
    
                         // Disc 
                         if (gameBoard[i, col] == 0)
                {
                    gameBoard[i, col] = player;
                    return true;
                }
    

                     // Disc could not
                     return false;
        }

}

}
