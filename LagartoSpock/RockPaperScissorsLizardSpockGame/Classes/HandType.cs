using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockGame.Classes
{
    public class HandType
    {
        static HandType()
        {
            None = new HandType();
            Paper = new HandType();
            Scissors = new HandType();
            Stone = new HandType();
        }
        protected HandType()
        {

        }
        public static HandType None { get; private set; }
        public static HandType Paper { get; private set; }
        public static HandType Scissors { get; private set; }
        public static HandType Stone { get; private set; }


    }
}
