using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum STATE
{
    STATE_IDLE, STATE_LIVE, STATE_END
}

public class Game_Manager : MonoBehaviour
{
    private static Game_Manager instance;

    public STATE GAME_STATE;

    public GameObject GangChi_OBJ;
    public GameObject Arrow;
    public GameObject NameTag;
    public GameObject IdleSceneBackGround;

    public static Game_Manager Instance
    {
        get
        {
            return instance;
        }
    }

    void Start()
    {
        GAME_STATE = STATE.STATE_IDLE;
        Idle_Scene_Init();     
    }

    void Idle_Scene_Init()
    {
        GameObject GC = Instantiate(GangChi_OBJ, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        RectTransform GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-250, 257, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);

        GameObject NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        RectTransform NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(809, -34, 0);
        TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "°­Ä¡";

        GameObject Arr = Instantiate(Arrow, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        RectTransform Arr_rt = Arr.GetComponent<RectTransform>();
        Arr_rt.localPosition = new Vector3(295, 184, 0);

    }

    void Update()
    {
        if (GAME_STATE != STATE.STATE_IDLE)
            IdleSceneBackGround.SetActive(false);
    }
}
