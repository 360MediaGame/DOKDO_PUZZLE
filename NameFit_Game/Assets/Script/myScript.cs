using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class myScript : MonoBehaviour
{
    private static myScript instance;

    TextMeshProUGUI nameText;

    public static myScript Instance
    {
        get
        {
            if (null == instance)
                return null;

            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        nameText = gameObject.GetComponent<TextMeshProUGUI>();
        //SetText("�ȳ�! ���� ��ġ��! �� �̸��� ��� �����!");  // test
    }

    public void SetText(string _text)
    {
        nameText.text = _text;
    }

    public string GetText()
    {
        return nameText.text;
    }
}
