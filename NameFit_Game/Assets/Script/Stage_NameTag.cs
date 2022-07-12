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

    public GameObject ClearWindow;

    RectTransform rectTransform;
    BoxCollider2D _bc;

    private GameObject _target;
    private Vector2 _start_pos;
    private Vector2 _target_pos;
    private bool _isAnswer;

    private void Awake()
    {
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
            _gAnswerCnt++;
            Debug.Log(_gAnswerCnt);

            // 이펙트
            GameObject Effect = Instantiate(_Effect, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform Effect_rt = Effect.GetComponent<RectTransform>();
            Effect_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);

            if (_gAnswerCnt >= 9)
            {
                myScript.Instance.SetText("정말 대단해! 열심히 공부했구나?");
                myScript.Instance.SetImpotantWord(0);
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == other.gameObject.name)
        {
            _target = other.gameObject;
            _target_pos.x = other.gameObject.GetComponent<RectTransform>().localPosition.x;
            _target_pos.y = other.gameObject.GetComponent<RectTransform>().localPosition.y;
            _isAnswer = true;
        }
        else
            _isAnswer = false;
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
