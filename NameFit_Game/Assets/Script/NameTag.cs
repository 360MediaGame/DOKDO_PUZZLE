using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NameTag : MonoBehaviour
    , IBeginDragHandler, IEndDragHandler, IDragHandler
{

    RectTransform rectTransform;
    BoxCollider2D _bc;

    private bool _dragend;
    private Vector2 _start_pos;

    private void Awake()
    {
        _bc = GetComponent<BoxCollider2D>();
        rectTransform = GetComponent<RectTransform>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    { 
        _start_pos.x = transform.position.x;
        _start_pos.y = transform.position.y;

        _dragend = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (gameObject.tag == "FixNameTag")
            return;
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = _start_pos;

       _dragend = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnDrop(PointerEventData eventData)
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 아마 안쓸듯?
        Debug.Log(other.gameObject.tag);
        Debug.Log(_dragend);
    }
}
