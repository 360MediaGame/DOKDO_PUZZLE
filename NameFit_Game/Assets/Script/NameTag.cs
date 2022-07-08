using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NameTag : MonoBehaviour
    , IBeginDragHandler, IEndDragHandler, IDragHandler
{

    RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnDrop(PointerEventData eventData)
    {

    }
}
