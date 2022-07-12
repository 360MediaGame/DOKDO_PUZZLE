using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Stage_Game_Manager : MonoBehaviour
{
    private static Stage_Game_Manager instance;
    
    // ��ġ�� OBJ �������� GRAY
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



    //public Texture m_Mt;

    public GameObject NameTag;

    public GameObject Gangchi_script_image;

    private float State_CurTime;

    private Vector2 Script_image_pos;

    private bool _isIdle;

    private bool _isoutlineinit;

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

        _isIdle = true;
        _isoutlineinit = false;

        myScript.Instance.SetWordTerm(true);
        Invoke("CallScript", 0.0f);
    }

    void Stage_Scene_Start()
    {
        //// Stage Scene���� ��ġ �ִϸ��̼� ����
        GameObject GC = Instantiate(GangChi_OBJ, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        GC.name = "Gangchi";
        RectTransform GC_rt = GC.GetComponent<RectTransform>();
        GC_rt.localPosition = new Vector3(-265, 100, 0);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        GC_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
        // �������� ��� �̹��� ����
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
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        GameObject NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.tag = "FixNameTag";
        RectTransform NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(-265, -20, 0);
        TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "��ġ";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "SONameTag";
        NT.tag = "SO";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(389, 123, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "��½��";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "SeagullTag";
        NT.tag = "Seagull";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(258, 261, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "���̰��ű�";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "BlackBirdTag";
        NT.tag = "BlackBird";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(224, -49, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "���ѱ�";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "HwangTag";
        NT.tag = "Hwang";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(716, 220, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "Ȳ��";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "DdackBirdTag";
        NT.tag = "DdackBird";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(539, -20, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "����";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "BlueDomTag";
        NT.tag = "BlueDom";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(817, -15, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "�Ķ���";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "BlueHwangTag";
        NT.tag = "BlueHwang";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(408, -199, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "ûȲ������ġ";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "BlackDomTag";
        NT.tag = "BlackDom";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(380, -392, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "�浼";

        NT = Instantiate(NameTag, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        NT.name = "MoonMeatTag";
        NT.tag = "MoonMeat";
        NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(750, -230, 0);
        nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        nameText.text = "�ް��";

        // Stage Scene���� �ϴ� ��ġ ��ũ��Ʈ �̹��� �ϳ� ����
        GameObject gc_si = Instantiate(Gangchi_script_image, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        RectTransform gc_si_rt = gc_si.GetComponent<RectTransform>();
        gc_si_rt.localPosition = new Vector3(Script_image_pos.x, Script_image_pos.y, 0);
    }

    void Update()
    {
        if (myScript.Instance.GetWordTerm() != _isIdle)
        {
            _isIdle = myScript.Instance.GetWordTerm();
            State_CurTime = 0f;
        }
        else
        {
            State_CurTime += Time.deltaTime;
        }

        if (State_CurTime >= 20f)
        {
            myScript.Instance.SetText("�ʶ�� �� �� �־�! ��� �����غ�!");
        }

        if (State_CurTime >= 120f)
        {
            Debug.Log("TIMEOUT_RESET");
            SceneManager.LoadScene("SampleScene");
        }

        if (!myScript.Instance.GetWordTerm())
        {
            Invoke("Runagain", 3.0f);
        }
    }

    void CallScript()
    {
        Invoke("CallScript", 5.0f);

        if (!myScript.Instance.GetWordTerm())
            return;

        if (myScript.Instance.GetIsClear())
            return;

        if (myScript.Instance.GetImpotantWord() == 8)
        {
            myScript.Instance.SetText("��½���� �û����� �� ������");
            myScript.Instance.SetImpotantWord(9);
        }
        else if (myScript.Instance.GetImpotantWord() == 9)
        {
            myScript.Instance.SetText("�ް��� �� �������̰� ��� ���� �־�");
            myScript.Instance.SetImpotantWord(10);
        }
        else if(myScript.Instance.GetImpotantWord() == 10)
        {
            myScript.Instance.SetText("�Ķ����� �������� ���� �Ƹ��ٿ�");
            myScript.Instance.SetImpotantWord(11);
        }
        else if (myScript.Instance.GetImpotantWord() == 11)
        {
            myScript.Instance.SetText("ûȲ������ġ�� ���� ������");
            myScript.Instance.SetImpotantWord(12);
        }
        else
        {
            myScript.Instance.SetText("������ ��û �Ϳ���!");
            myScript.Instance.SetImpotantWord(8);
        }      
    }

    void Runagain()
    {
        myScript.Instance.SetWordTerm(true);
        //CallScript();
    }

    public void SetOutLineInit(bool _oli)
    {
        _isoutlineinit = _oli;
    }

    public bool GetOutLineInit()
    {
        return _isoutlineinit;
    }
}
