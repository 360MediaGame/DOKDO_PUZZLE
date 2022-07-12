using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public enum STATE
{
    STATE_IDLE, STATE_LIVE, STATE_END
}

public class Game_Manager : MonoBehaviour
{
    private static Game_Manager instance;

    public STATE GAME_STATE;

    public GameObject Gangchi_GRAY;
    public GameObject GangChi_OBJ;
    public GameObject Arrow;
    public GameObject NameTag;
    public GameObject IdleSceneBackGround;

    public GameObject Gangchi_script_image;

    public string IdleScript1;
    public string IdleScript2;

    private float Idle_CurTime;
    private float OutLine_CurTime;
    private float State_CurTime;

    private Vector2 Script_image_pos;
    GameObject GC;
    float OutlineWidth;
    bool isup;
    public static Game_Manager Instance
    {
        get
        {
            return instance;
        }
    }

    void Start()
    {
        Script_image_pos = new Vector2(176, 432);
        OutlineWidth = 0.000f;
        isup = true;
        myScript.Instance.SetText(IdleScript1);

        GAME_STATE = STATE.STATE_IDLE;
        Idle_Scene_Init();     
    }

    void Idle_Scene_Init()
    {
        GC = Instantiate(Gangchi_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "Gangchi";
        RectTransform GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-265, 100, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);

        GameObject Arr = Instantiate(Arrow, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        RectTransform Arr_rt = Arr.GetComponent<RectTransform>();
        Arr_rt.localPosition = new Vector3(295, 27, 0);

        // IDLE Scene에선 강치 하나 생성
        GameObject NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "GangChiNameTag";
        NT.tag = "Gangchi";
        RectTransform NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(809, -191, 0);
        TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "강치";

        // IDLE Scene에선 강치 스크립트 이미지 하나 생성
        GameObject gc_si = Instantiate(Gangchi_script_image, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        RectTransform gc_si_rt = gc_si.GetComponent<RectTransform>();
        gc_si_rt.localPosition = new Vector3(Script_image_pos.x, Script_image_pos.y, 0);
    }

    void Update()
    {
        if (GAME_STATE == STATE.STATE_IDLE)
        {
            Idle_CurTime += Time.deltaTime;
            OutLine_CurTime += Time.deltaTime;

            if (Idle_CurTime > 10f)
            {
                if (myScript.Instance.GetText() == IdleScript1)
                {
                    myScript.Instance.SetText(IdleScript2);
                }
                else if (myScript.Instance.GetText() == IdleScript2)
                {
                    myScript.Instance.SetText(IdleScript1);
                }
                Idle_CurTime = 0f;
            }

            if (OutLine_CurTime > 0.1f)
            {
                if (isup)
                    OutlineWidth += 0.001f;
                else
                    OutlineWidth -= 0.001f;
                OutLine_CurTime = 0.0f;
            }

            if (OutlineWidth >= 0.017f)
                isup = false;
            if (OutlineWidth <= 0.000f)
                isup = true;

            GC.GetComponent<Image>().material.SetFloat("_OutlineWidth", OutlineWidth);
        }
        if (GAME_STATE != STATE.STATE_IDLE)
            IdleSceneBackGround.SetActive(false);
    }
}
