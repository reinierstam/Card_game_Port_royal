using System;
using Cards.CardType;

namespace Assets.Scripts.GameObjects.Cards.ImplementedCards
{
    class AdmiralCard : ICard
    {      
        private int points = 0;
        private cardType type = cardType.Admiral;
        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public cardType Type
        {
            get
            {
                return type; 
            }

            set
            {
                type = value;
            }
        }
    }
}
