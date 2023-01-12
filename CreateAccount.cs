using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public class CreateAccount
    {
        private static int index_Player;
        public BonusAccount Bonus_Account()
        {
            return new BonusAccount("player" + (++index_Player));
        }

        public GameAccount Game_Account()
        {
            return new GameAccount("player" + (++index_Player));
        }

        public HardAccount Hard_Account()
        {
            return new HardAccount("player" + (++index_Player));
        }
    }
}
