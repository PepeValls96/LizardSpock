using RockPaperScissorsLizardSpockGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockGame.Interfaces
{
    public interface IRockPaperScissorsGame
    {
        HandType Play(HandType hand1, HandType hand2);

    }
}
