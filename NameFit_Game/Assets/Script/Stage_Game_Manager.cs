using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage_Game_Manager : MonoBehaviour
{
    private static Stage_Game_Manager instance;

    
    // 강치는 OBJ 나머지는 GRAY
    public GameObject GangChi_OBJ;
    public GameObject Blackbird_GRAY;
    public GameObject Blackdom_GRAY;
    public GameObject Bluedom_GRAY;
    public GameObject Bluehwang_GRAY;
    public GameObject Ddackbird_GRAY;
    public GameObject Hwang_GRAY;
    public GameObject Moonmeat_GRAY;
    public GameObject Seagull_GRAY;
    public GameObject SO_GRAY;

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
#pragma region [CreateAnimalImage]
        //// Stage Scene에선 강치 애니메이션 생성
        GameObject GC = Instantiate(GangChi_OBJ, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "Gangchi";
        RectTransform GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-265, 100, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
        // 나머지는 흑백 이미지 생성
        GC = Instantiate(Blackbird_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "BlackBird";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-286, 390, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);

        GC = Instantiate(Blackdom_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "BlackDom";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-100, -254, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);

        GC = Instantiate(Bluedom_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "BlueDom";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-766, -17, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);

        GC = Instantiate(Bluehwang_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "BlueHwang";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-336, -84, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);

        GC = Instantiate(Ddackbird_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "DdackBird";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-63, 350, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);

        GC = Instantiate(Hwang_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "Hwang";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-438, 239, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);

        GC = Instantiate(Moonmeat_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "MoonMeat";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-514, -234, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);

        GC = Instantiate(Seagull_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "Seagull";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-795, 255, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);

        GC = Instantiate(SO_GRAY, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "SO";
        GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-615, 390, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
#pragma endregion [CreateAnimalImage]

        GameObject NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "SONameTag";
        NT.tag = "SO";
        RectTransform NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(389, 123, 0);
        TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "소쩍새";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "SeagullTag";
        NT.tag = "Seagull";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(258, 261, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "괭이갈매기";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "BlackBirdTag";
        NT.tag = "BlackBird";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(224, -49, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "흑비둘기";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "HwangTag";
        NT.tag = "Hwang";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(716, 220, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "황로";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "DdackBirdTag";
        NT.tag = "DdackBird";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(539, -20, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "딱새";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "BlueDomTag";
        NT.tag = "BlueDom";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(817, -15, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "파랑돔";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "BlueHwangTag";
        NT.tag = "BlueHwang";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(408, -199, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "청황베도라치";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "BlackDomTag";
        NT.tag = "BlackDom";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(380, -392, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "흑돔";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "MoonMeatTag";
        NT.tag = "MoonMeat";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(750, -230, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "달고기";

        // Stage Scene에선 일단 강치 스크립트 이미지 하나 생성
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
