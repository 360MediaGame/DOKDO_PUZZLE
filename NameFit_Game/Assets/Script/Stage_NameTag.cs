using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Stage_NameTag : MonoBehaviour
    , IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static int _gAnswerCnt = 0;

    public GameObject _Effect;

    public GameObject BlackBird_ani;
    public GameObject BlackDom_ani;
    public GameObject BlueDom_ani;
    public GameObject BlueHwang_ani;
    public GameObject DdackBird_ani;
    public GameObject Hwang_ani;
    public GameObject MoonMeat_ani;
    public GameObject Seagull_ani;
    public GameObject SO_ani;

    public GameObject BlackBird_outline;
    public GameObject BlackDom_outline;
    public GameObject BlueDom_outline;
    public GameObject BlueHwang_outline;
    public GameObject DdackBird_outline;
    public GameObject Hwang_outline;
    public GameObject MoonMeat_outline;
    public GameObject Seagull_outline;
    public GameObject SO_outline;

    public GameObject ClearWindow;

    //public GameObject AnswerManager;

    RectTransform rectTransform;
    BoxCollider2D _bc;

    private GameObject _target;
    private Vector2 _start_pos;
    private Vector2 _target_pos;
    private bool _isAnswer;

    private GameObject[] OutlineImage;

    private void Awake()
    {
        OutlineImage = new GameObject[9];
        _bc = GetComponent<BoxCollider2D>();
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _start_pos.x = transform.position.x;
        _start_pos.y = transform.position.y;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (gameObject.tag == "FixNameTag")
            return;
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = _start_pos;

        Debug.Log("isAnswer " + _isAnswer);

        if (_isAnswer)
        {
            if (_target.name == "BlackBird")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "흑비둘기";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(BlackBird_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            if (_target.name == "BlackDom")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "흑돔";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(BlackDom_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            if (_target.name == "BlueDom")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "파랑돔";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(BlueDom_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            if (_target.name == "BlueHwang")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "청황베도라치";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(BlueHwang_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            if (_target.name == "DdackBird")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "딱새";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(DdackBird_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            if (_target.name == "Hwang")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "황로";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(Hwang_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            if (_target.name == "MoonMeat")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "달고기";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(MoonMeat_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            if (_target.name == "Seagull")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "괭이갈매기";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(Seagull_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            if (_target.name == "SO")
            {
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "소쩍새";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(SO_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }


            myScript.Instance.SetText("훌륭해! 다음 독도 친구들도 맞추어 볼까?");
            myScript.Instance.SetWordTerm(false);


            AnswerManager.Instance.AnserCntPlusOne();
            Debug.Log(AnswerManager.Instance.GetAnserCnt());

            // 이펙트
            GameObject Effect = Instantiate(_Effect, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform Effect_rt = Effect.GetComponent<RectTransform>();
            Effect_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);

            if (AnswerManager.Instance.GetAnserCnt() >= 9)
            {
                myScript.Instance.SetText("정말 대단해! 열심히 공부했구나?");
                myScript.Instance.SetImpotantWord(0);
                myScript.Instance.SetIsClear(true);
                AnswerManager.Instance.ResetAnserCnt();
                Invoke("EndStageScene", 3f);
            }

            gameObject.SetActive(false);
        }
        else
        {
            myScript.Instance.SetText("그 친구의 이름이 아니야, 다시 도전해보자!");
            myScript.Instance.SetWordTerm(false);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnDrop(PointerEventData eventData)
    {
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (gameObject.tag == other.gameObject.name)
        {
            _target = other.gameObject;
            _target_pos.x = other.gameObject.GetComponent<RectTransform>().localPosition.x;
            _target_pos.y = other.gameObject.GetComponent<RectTransform>().localPosition.y;
            _isAnswer = true;

            Debug.Log(_target.name);
        }
        else
        {
            _isAnswer = false;
        }

        if (other.gameObject.name == "BlackBird")
        {
            if (OutlineImage[0])
                return;

            OutlineImage[0] = Instantiate(BlackBird_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[0].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-286, 390, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
        }
        else if (other.gameObject.name == "BlackDom")
        {
            if (OutlineImage[1])
                return;
            OutlineImage[1] = Instantiate(BlackDom_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[1].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-100, -254, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
        }
        else if (other.gameObject.name == "BlueDom")
        {
            if (OutlineImage[2])
                return;
            OutlineImage[2] = Instantiate(BlueDom_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[2].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-766, -14, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
        }
        else if (other.gameObject.name == "BlueHwang")
        {
            if (OutlineImage[3])
                return;
            OutlineImage[3] = Instantiate(BlueHwang_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[3].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-336, -84, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
        }
        else if (other.gameObject.name == "DdackBird")
        {
            if (OutlineImage[4])
                return;
            OutlineImage[4] = Instantiate(DdackBird_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[4].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-63, 350, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
        }
        else if (other.gameObject.name == "Hwang")
        {
            if (OutlineImage[5])
                return;
            OutlineImage[5] = Instantiate(Hwang_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[5].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-438, 239, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
        }
        else if (other.gameObject.name == "MoonMeat")
        {
            if (OutlineImage[6])
                return;
            OutlineImage[6] = Instantiate(MoonMeat_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[6].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-514, -234, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
        }
        else if (other.gameObject.name == "Seagull")
        {
            if (OutlineImage[7])
                return;
            OutlineImage[7] = Instantiate(Seagull_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[7].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-795, 255, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
        }
        else if (other.gameObject.name == "SO")
        {
            if (OutlineImage[8])
                return;
            OutlineImage[8] = Instantiate(SO_outline, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform NT_rt = OutlineImage[8].GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(-615, 390, 0);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
            NT_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (gameObject.tag == other.gameObject.name)
        {
            _isAnswer = false;
            Debug.Log("떨어짐");
        }

        if (other.gameObject.name == "BlackBird")
            Destroy(OutlineImage[0]);
        if (other.gameObject.name == "BlackDom")
            Destroy(OutlineImage[1]);
        if (other.gameObject.name == "BlueDom")
            Destroy(OutlineImage[2]);
        if (other.gameObject.name == "BlueHwang")
            Destroy(OutlineImage[3]);
        if (other.gameObject.name == "DdackBird")
            Destroy(OutlineImage[4]);
        if (other.gameObject.name == "Hwang")
            Destroy(OutlineImage[5]);
        if (other.gameObject.name == "MoonMeat")
            Destroy(OutlineImage[6]);
        if (other.gameObject.name == "Seagull")
            Destroy(OutlineImage[7]);
        if (other.gameObject.name == "SO")
            Destroy(OutlineImage[8]);
    }

    private void EndStageScene()
    {
        // 팝업창 띄우기
        //Debug.Log(ClearWindow.Instance.gameObject.name); //SetActive(true);
        GameObject NT = Instantiate(ClearWindow, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        RectTransform NT_rt = NT.GetComponent<RectTransform>();
        NT_rt.localPosition = new Vector3(0, 0, 0);
    }
}
