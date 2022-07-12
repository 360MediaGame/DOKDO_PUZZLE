using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NameTag : MonoBehaviour
    , IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public GameObject _Effect;
    public GameObject Gangchi_ani;

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
            if (_target.name == "Gangchi")
            {       
                // FixNameTag
                GameObject NT = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "강치";

                // AniObj
                Destroy(_target);
                GameObject ani_obj = Instantiate(Gangchi_ani, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
                ani_obj_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);
            }
            myScript.Instance.SetText("훌륭해! 다음 독도 친구들도 맞추어 볼까?");

            // 이펙트
            GameObject Effect = Instantiate(_Effect, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform Effect_rt = Effect.GetComponent<RectTransform>();
            Effect_rt.localPosition = new Vector3(_target_pos.x, _target_pos.y, 0);

            Invoke("EnterStageScene", 3f);

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
