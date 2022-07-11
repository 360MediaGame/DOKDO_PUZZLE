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
                nameText.text = "ÈæºñµÑ±â";

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
                nameText.text = "Èæµ¼";

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
                nameText.text = "ÆÄ¶ûµ¼";

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
                nameText.text = "Ã»È²º£µµ¶óÄ¡";

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
                nameText.text = "µü»õ";

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
                nameText.text = "È²·Î";

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
                nameText.text = "´Þ°í±â";

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
                nameText.text = "±ªÀÌ°¥¸Å±â";

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
                nameText.text = "¼ÒÂ½»õ";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(SO_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }


            myScript.Instance.SetText("ÈÇ¸¢ÇØ! ´ÙÀ½ µ¶µµ Ä£±¸µéµµ ¸ÂÃß¾î º¼±î?");

            // ÀÌÆåÆ®
            GameObject Effect = Instantiate(_Effect, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform Effect_rt = Effect.GetComponent<RectTransform>();
            Effect_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);

            //Invoke("EnterStageScene", 3f);

            gameObject.SetActive(false);
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

    private void EnterStageScene()
    {
        SceneManager.LoadScene("STAGE_SCENE");
    }
}
