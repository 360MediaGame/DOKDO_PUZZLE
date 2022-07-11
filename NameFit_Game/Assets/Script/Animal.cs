using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Animal : MonoBehaviour
{
    public GameObject GangChi_OBJ;

    public GameObject _nameTagPrefab;
    public GameObject _Effect;

    BoxCollider2D _bc;
    Rigidbody2D _rigid;

    RectTransform ani_rt;
    void Start()
    {
        _bc = GetComponent<BoxCollider2D>();
        _rigid = GetComponent<Rigidbody2D>();
        ani_rt = gameObject.GetComponent<RectTransform>();
        //var outline;
        //outline = gameObject.AddComponent<Outline>();

        //outline.OutlineMode = Outline.Mode.OutlineAll;
        //outline.OutlineColor = Color.yellow;
        //outline.OutlineWidth = 5f;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);

        if (gameObject.name == other.tag)
        {
            if (gameObject.name == "Gangchi")
            {
                GameObject NT = Instantiate(_nameTagPrefab, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                NT.tag = "FixNameTag";
                RectTransform NT_rt = NT.GetComponent<RectTransform>();
                NT_rt.localPosition = new Vector3(ani_rt.localPosition.x, ani_rt.localPosition.y - 120, 0);
                TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
                nameText.text = "강치";

                GameObject ani_obj = Instantiate(GangChi_OBJ, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
                RectTransform ani_obj_rt = ani_obj.GetComponent<RectTransform>();
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
                ani_obj_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
                ani_obj_rt.localPosition = new Vector3(ani_rt.localPosition.x, ani_rt.localPosition.y, 0);
            }
            

            myScript.Instance.SetText("훌륭해! 다음 독도 친구들도 맞추어 볼까?");

            GameObject Effect = Instantiate(_Effect, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            RectTransform Effect_rt = Effect.GetComponent<RectTransform>();
            Effect_rt.localPosition = new Vector3(ani_rt.localPosition.x, ani_rt.localPosition.y, 0);

            Invoke("EnterStageScene", 3f);

            Destroy(other.gameObject);
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    private void EnterStageScene()
    {
        SceneManager.LoadScene("STAGE_SCENE");
    }
}
