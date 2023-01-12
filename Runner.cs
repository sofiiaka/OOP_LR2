using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public static class Runner
    {
        static void Main()
        {
            UsuallyGame usuallyGame = new UsuallyGame();
            TrainGame trainingGame = new TrainGame();
            OneRatingGame oneRatingGame = new OneRatingGame();

            var Denis = new GameAccount("Denis");
            var Artem = new GameAccount("Artem");

            var Ivan = new HardAccount("Ivan");
            var Vlad = new HardAccount("Vlad");

            var Sasha = new BonusAccount("Sasha");
            var Boris = new BonusAccount("Boris");

            Denis.WinGame(Artem, usuallyGame);
            Denis.LoseGame(Artem, usuallyGame);

            Denis.WinGame(Artem, oneRatingGame);
            Denis.LoseGame(Artem, oneRatingGame);

            Sasha.WinGame(Boris, trainingGame);
            Sasha.WinGame(Boris, trainingGame);
            Sasha.WinGame(Boris, trainingGame);

            Ivan.WinGame(Vlad, usuallyGame);
            Ivan.LoseGame(Vlad, usuallyGame);

            CreateAccount createAccount = new CreateAccount();
            BonusAccount player1 = createAccount.Bonus_Account();
            GameAccount player2 = createAccount.Game_Account();
            HardAccount player3 = createAccount.Hard_Account();

            player1.WinGame(player2, usuallyGame);
            player1.LoseGame(player2, usuallyGame);

            player2.LoseGame(player3, usuallyGame);
            player2.LoseGame(player3, oneRatingGame);

            Account.HistoryGames();

            Console.WriteLine(Denis.current_rating);
            Console.WriteLine(Artem.current_rating);
            Console.WriteLine(Sasha.current_rating);
            Console.WriteLine(Boris.current_rating);
            Console.WriteLine(Ivan.current_rating);
            Console.WriteLine(Vlad.current_rating);
        }
    }
}
