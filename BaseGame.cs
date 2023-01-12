using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr2
{
    public abstract class BaseGame
    {
        public string Type;
        protected static Random Random = new Random();

        public abstract int Game(Account account1, Account account2, Result result);

        public enum Result
        {
            Winner,
            Lose,
        }

        protected enum TypeGame
        {
            Normally,
            OneRating,
            Training,
        }
    }
}
