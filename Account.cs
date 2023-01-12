using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public abstract class Account
    {
        protected LevelAccount level;
        protected int win_games_amount; 
        public int Rating_k; // RatingCoefficient
        public int current_rating;
        protected string user_name;
        private static int count_games;
        private static readonly List<GameList> game_lists = new List<GameList>();

        public void WinGame(Account another_player, BaseGame typeGames)
        {
            int rating = typeGames.Game(this, another_player, BaseGame.Result.Winner);
            if (level == LevelAccount.Easy)
            {
                if (++win_games_amount == 3)
                {
                    current_rating += 150;
                    win_games_amount = 0;
                }                                                   
            }

            game_lists.Add(new GameList(++count_games, typeGames.Type, this, another_player, "Win", rating));
        }

        public void LoseGame(Account another_player, BaseGame typeGames)
        {
            int rating = typeGames.Game(this, another_player, BaseGame.Result.Lose);
            if (level == LevelAccount.Easy)
            {
                win_games_amount = 0;
            }

            game_lists.Add(new GameList(++count_games, typeGames.Type, this, another_player, "Lose", rating));
        }

        public static void HistoryGames()
        {
            foreach (var game in game_lists)
            {
                Console.WriteLine("ID: " + game.count_games);
                Console.WriteLine("Type Game: " + game.Type);
                Console.WriteLine("Player 1: " + game.player_1.user_name);
                Console.WriteLine("Player 2: " + game.player_2.user_name);
                Console.WriteLine(game.player_1.user_name + " " + game.Result);
                Console.WriteLine("Rating: " + game.Rating);
                Console.WriteLine();
            }
        }

        protected enum LevelAccount
        {
            Easy,
            Usually,
            Hard,
        }
    }
}
