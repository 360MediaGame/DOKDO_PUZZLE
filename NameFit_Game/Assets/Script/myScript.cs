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
            "안녕! 나는 강치야! 내 이름을 끌어서 맞춰봐!",
            "같이 독도 친구들의 이름을 알아볼까?",
            "너라면 할 수 있어! 계속 도전해봐!",
            "훌륭해! 다음 독도 친구들도 맞추어 볼까?",
            "그 친구의 이름이 아니야, 다시 도전해보자!",
            "정말 대단해! 열심히 공부했구나?",
            "무슨일이야? 문제가 너무 어려워?",
            "딱새는 엄청 귀여워!",
            "소쩍새는 올빼미의 한 종류야",
            "달고기는 등 지느러미가 길게 뻗어 있어",
            "파랑돔은 지느러미 색이 아름다워",
            "청황베도라치는 몸이 길쭉해"
        };

        Debug.Log(scripts[0]);
    }

    void Start()
    {
        nameText = gameObject.GetComponent<TextMeshProUGUI>();
        //SetText("안녕! 나는 강치야! 내 이름을 끌어서 맞춰봐!");  // test
    }

    public void SetTextIndex(int _index)
    {
        // 일단 안돌아감 이건       
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
