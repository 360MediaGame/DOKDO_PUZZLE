using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class myScript : MonoBehaviour
{
    private static myScript instance;

    TextMeshProUGUI nameText;

    public int _ImpotantWord;
    public bool _wordterm = true;
    public static string[] scripts;

    private int curIndex;
    private bool isclear = false;

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

        curIndex = 1;
        string[] scripts = { 
            "�ȳ�! ���� ��ġ��! �� �̸��� ��� �����!",
            "���� ���� ģ������ �̸��� �˾ƺ���?",
            "�ʶ�� �� �� �־�! ��� �����غ�!",
            "�Ǹ���! ���� ���� ģ���鵵 ���߾� ����?",
            "�� ģ���� �̸��� �ƴϾ�, �ٽ� �����غ���!",
            "���� �����! ������ �����߱���?",
            "�������̾�? ������ �ʹ� �����?",
            "������ ��û �Ϳ���!",
            "��½���� �û����� �� ������",
            "�ް��� �� �������̰� ��� ���� �־�",
            "�Ķ����� �������� ���� �Ƹ��ٿ�",
            "ûȲ������ġ�� ���� ������"
        };

        Debug.Log(scripts[0]);
    }

    void Start()
    {
        nameText = gameObject.GetComponent<TextMeshProUGUI>();
        //SetText("�ȳ�! ���� ��ġ��! �� �̸��� ��� �����!");  // test
    }

    public void SetTextIndex(int _index)
    {
        // �ϴ� �ȵ��ư� �̰�       
        nameText.text = scripts[_index];
        curIndex = _index;
    }

    public int GetCurIndex()
    {
        return curIndex;
    }

    public string GetCurText(int _index)
    {
        return scripts[_index];
    }

    public void SetText(string _text)
    {
        nameText.text = _text;
    }

    public string GetText()
    {
        return nameText.text;
    }

    public void SetImpotantWord(int _isiw)
    {
        _ImpotantWord = _isiw;
    }

    public int GetImpotantWord()
    {
        return _ImpotantWord;
    }

    public void SetWordTerm(bool _wt)
    {
        _wordterm = _wt;
    }

    public bool GetWordTerm()
    {
        return _wordterm;
    }

    public void SetIsClear(bool _ic)
    {
        isclear = _ic;
    }

    public bool GetIsClear()
    {
        return isclear;
    }
}
