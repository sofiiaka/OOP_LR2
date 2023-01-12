using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public class BonusAccount : Account
    {
        public BonusAccount(string userName)
        {
            Rating_k = 1;
            level = LevelAccount.Easy;
            user_name = userName;
            current_rating = 1000;
            win_games_amount = 0;
        }
    }
}

