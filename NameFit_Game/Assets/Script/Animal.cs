using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal : MonoBehaviour
{
    public GameObject _nameTagPrefab;

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
            GameObject NT = Instantiate(_nameTagPrefab, gameObject.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
            NT.tag = "FixNameTag";
            RectTransform NT_rt = NT.GetComponent<RectTransform>();
            NT_rt.localPosition = new Vector3(ani_rt.localPosition.x, ani_rt.localPosition.y - 120, 0);
            TextMeshProUGUI nameText = NT.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
            nameText.text = gameObject.name;

            myScript.Instance.SetText("훌륭해! 다음 독도 친구들도 맞추어 볼까?");

            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("dd");
        }
    }
}
