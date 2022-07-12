using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    private static AnswerManager instance;
    public static int _gAnswerCnt = 0;

    public static AnswerManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    public void AnserCntPlusOne()
    {
        _gAnswerCnt++;
    }

    public int GetAnserCnt()
    {
        return _gAnswerCnt;
    }

    public void ResetAnserCnt()
    {
        _gAnswerCnt = 0;
    }
}
