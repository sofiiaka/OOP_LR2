using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public class TrainGame : BaseGame
    {
        public TrainGame()
        {
            Type = TypeGame.Training.ToString();
        }
        public override int Game(Account account_1, Account account_2, Result result)
        {
            return 0;
        }
    }
}
