using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockGame.Classes
{
    public class ExtendedHandType : HandType
    {

        static ExtendedHandType()
        {
            Lizard = new ExtendedHandType();
            Spock = new ExtendedHandType();
        }
        public static ExtendedHandType Lizard { get; private set; }
        public static ExtendedHandType Spock { get; private set; }
    }
}