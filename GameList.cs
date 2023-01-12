using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public class GameList
    {
        public int count_games;
        public string Type;
        public Account player_1;
        public Account player_2;
        public string Result;
        public int Rating;
        public GameList(int games_Count, string type, Account player1, Account player2, string result, int rating)
        {
            count_games = games_Count;
            Type = type;
            player_1 = player1;
            player_2 = player2;
            Result = result;
            Rating = rating;
        }
    }
}
