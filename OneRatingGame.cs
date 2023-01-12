using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public class OneRatingGame : BaseGame
    {
        public OneRatingGame()
        {
            Type = TypeGame.OneRating.ToString();
        }
        public override int Game(Account account_1, Account account_2, Result result)
        {
            int rating = Random.Next(90, 120);

            if (result == Result.Winner)
            {
                account_2.current_rating -= account_2.Rating_k * rating;
            }
            else
            {
                account_2.current_rating += rating;
            }

            return rating;
        }
    }
}
