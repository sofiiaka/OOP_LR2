using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public class GameAccount : Account
    {
        public GameAccount(string userName)
        {
            Rating_k = 1;
            level = LevelAccount.Usually;
            user_name = userName;
            current_rating = 1000;
        }
    }
}


