using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ScriptImage : MonoBehaviour, IPointerClickHandler
{
    BoxCollider2D _bc;
    Scene scene;

    private void Awake()
    {
        _bc = GetComponent<BoxCollider2D>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (scene.name == "STAGE_SCENE")
        {
            myScript.Instance.SetText("�������̾�? ������ �ʹ� �����?");
            myScript.Instance.SetWordTerm(false);
        }
    }
}
