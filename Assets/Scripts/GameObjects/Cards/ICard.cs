using System;
using Cards.CardType;

namespace Assets.Scripts.GameObjects.Cards
{
    interface ICard
    {
        int Points { get; set; }
        cardType Type { get; set; }             
    }
}
