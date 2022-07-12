using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    //BoxCollider2D _bc;
    //Rigidbody2D _rigid;

    private Image img;

    //RectTransform ani_rt;
    void Start()
    {
        img = GetComponent<Image>();
        Debug.Log(img.material.name);
        //img.material = None;
        //_bc = GetComponent<BoxCollider2D>();
        //_rigid = GetComponent<Rigidbody2D>();
        //ani_rt = gameObject.GetComponent<RectTransform>();
        //var outline;
        //outline = gameObject.AddComponent<Outline>();

        //outline.OutlineMode = Outline.Mode.OutlineAll;
        //outline.OutlineColor = Color.yellow;
        //outline.OutlineWidth = 5f;
    }

    void Update()
    {
        
    }



}
