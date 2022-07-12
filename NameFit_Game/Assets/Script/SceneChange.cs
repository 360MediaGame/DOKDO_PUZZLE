using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeToStage()
    {
        AnswerManager.Instance.ResetAnserCnt();
        SceneManager.LoadScene("STAGE_SCENE");
    }

    public void ChangeToIdle()
    {
        AnswerManager.Instance.ResetAnserCnt();
        SceneManager.LoadScene("SampleScene");
    }
}
