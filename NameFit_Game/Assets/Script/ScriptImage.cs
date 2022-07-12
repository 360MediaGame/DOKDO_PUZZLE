using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScriptImage : MonoBehaviour, IPointerClickHandler
{
    BoxCollider2D _bc;

    private void Awake()
    {
        _bc = GetComponent<BoxCollider2D>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        myScript.Instance.SetText("�������̾�? ������ �ʹ� �����?");
        myScript.Instance.SetWordTerm(false);
    }
}
