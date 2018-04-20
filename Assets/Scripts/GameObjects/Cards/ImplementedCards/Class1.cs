using System;
using Cards.CardType;

namespace Assets.Scripts.GameObjects.Cards.ImplementedCards
{
    public abstract class AbstractCard : ICard
    {
        private int points = 0;
        private cardType type;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public cardType Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
