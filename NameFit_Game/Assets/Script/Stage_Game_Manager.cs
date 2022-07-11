using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage_Game_Manager : MonoBehaviour
{
    private static Stage_Game_Manager instance;

    public GameObject Gangchi_GRAY;
    public GameObject GangChi_OBJ;

    public GameObject NameTag;

    public GameObject Gangchi_script_image;

    private float State_CurTime;

    private Vector2 Script_image_pos;

    public static Stage_Game_Manager Instance
    {
        get
        {
            return instance;
        }
    }

    void Start()
    {
        Script_image_pos = new Vector2(176, 432);

       Stage_Scene_Start();     
    }

    void Stage_Scene_Start()
    {
        GameObject GC = Instantiate(Gangchi_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "Gangchi";
        RectTransform GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-250, 257, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);


        // IDLE Scene에선 강치 하나 생성
        GameObject NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "GangChiNameTag";
        NT.tag = "Gangchi";
        RectTransform NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(809, -34, 0);
        TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "강치";

        // IDLE Scene에선 강치 스크립트 이미지 하나 생성
        GameObject gc_si = Instantiate(Gangchi_script_image, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        RectTransform gc_si_rt = gc_si.GetComponent<RectTransform>();
        gc_si_rt.localPosition = new Vector3(Script_image_pos.x, Script_image_pos.y, 0);
    }

    void Update()
    {
        //if (GAME_STATE == STATE.STATE_IDLE)
        //{
        //    Idle_CurTime += Time.deltaTime;

        //    if (Idle_CurTime > 10f)
        //    {
        //        if (myScript.Instance.GetText() == IdleScript1)
        //        {
        //            myScript.Instance.SetText(IdleScript2);
        //        }
        //        else if (myScript.Instance.GetText() == IdleScript2)
        //        {
        //            myScript.Instance.SetText(IdleScript1);
        //        }
        //        Idle_CurTime = 0f;
        //    }

        //    //Debug.Log(Idle_CurTime);
        //}
        //if (GAME_STATE != STATE.STATE_IDLE)
        //IdleSceneBackGround.SetActive(false);
    }
}
