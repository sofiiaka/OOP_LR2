using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public class HardAccount : Account
    {
        public HardAccount(string user_Name)
        {
            Rating_k = 2;
            level = LevelAccount.Hard;
            user_name = user_Name;
            current_rating = 700;
        }
    }
}
