using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameAction OnCardHover;
    public CardAction OnCardSelected;

    // Start is called before the first frame update
    void Start()
    {
        OnCardHover.Trigger += OnCardHoverFunction;
        OnCardSelected.Trigger += OnCardSelectedFunction;
    }

    void OnCardHoverFunction(GameObject card)
    {
        Debug.Log("I hovered this card: " + card.name);
    }

    void OnCardSelectedFunction(CardValue card)
    {
        Debug.Log("I selected this card: " + card.name);
    }
}
