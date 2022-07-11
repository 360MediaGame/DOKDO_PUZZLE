using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeToStage()
    {
        SceneManager.LoadScene("STAGE_SCENE");
    }

    public void ChangeToIdle()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
