using RockPaperScissorsLizardSpockGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockGame.PlayGame
{
    public class WithLizardSpockGame: RockPaperScissorsGame
    {
        public WithLizardSpockGame()
        {
            winCombinations[HandType.Paper].Add(ExtendedHandType.Spock);
            winCombinations[HandType.Stone].Add(ExtendedHandType.Lizard);
            winCombinations[HandType.Scissors].Add(ExtendedHandType.Lizard);
            winCombinations.Add(ExtendedHandType.Spock, new List<HandType> { HandType.Scissors, HandType.Stone});
            winCombinations.Add(ExtendedHandType.Lizard, new List<HandType> { HandType.Paper, ExtendedHandType.Spock});
        } 
    }
}
