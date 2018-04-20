using UnityEngine;
using Cards.CardType;
using Assets.Scripts.GameObjects.Cards.ImplementedCards;

public class CardFactory : MonoBehaviour {

    // Use this for initialization
    public CardDefault GetCard(cardType cardType)
    {
        CardDefault NewCard = new CardDefault();
        switch (cardType)
        {
            case cardType.Admiral :
                

                break;
            default:
                NewCard.FacedFront = false;
                break;
        }
        return new CardDefault();
    }
}
