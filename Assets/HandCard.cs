using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HandCard : MonoBehaviour, IPointerClickHandler
{
    public GameAction OnCardHover;
    public CardAction OnCardSelected;

    public CardValue CardData;

    public void OnHoverEnter()
    {
        transform.localScale = Vector3.one * 1.2f;
        OnCardHover.Trigger.Invoke(gameObject);
    }

    public void OnHoverExit()
    {
        transform.localScale = Vector3.one * 1f;
        OnCardHover.Trigger.Invoke(gameObject);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnCardSelected.Trigger.Invoke(CardData);
    }
}
