using RockPaperScissorsLizardSpockGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockGame.PlayGame
{
    public class RockPaperScissorsGame : IRockPaperScissorsGame
    {
        protected Dictionary<HandType, List<HandType>> winCombinations = new Dictionary<HandType, List<HandType>>()
        {
            {HandType.Paper, new List<HandType>{ HandType.Stone}},
            {HandType.Stone, new List<HandType>{ HandType.Scissors}},
            {HandType.Scissors, new List<HandType>{ HandType.Paper}},
        };

        public HandType GetWinHand(HandType hand1, HandType hand2)
        {
            HandType result = new HandType();


            if (winCombinations[hand1].Contains(hand2))
            {
                result = hand1;
            }
            else
            {
                result = hand2;
            }


            return result;
        }
        public HandType Play(HandType hand1, HandType hand2)
        {
            HandType result = HandType.None;
            if (winCombinations.Keys.Contains(hand1) && winCombinations.Keys.Contains(hand2))
            {
                if (hand1 == HandType.None || hand2 == HandType.None)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (hand1 == hand2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    result = GetWinHand(hand1, hand2);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            return result;
        }
        
    }  
}
