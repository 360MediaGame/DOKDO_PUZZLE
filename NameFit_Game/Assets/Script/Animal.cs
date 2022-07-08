using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    BoxCollider2D _bc;
    Rigidbody2D _rigid;

    void Start()
    {
        _bc = GetComponent<BoxCollider2D>();
        _rigid = GetComponent<Rigidbody2D>();
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
        Debug.Log("Test!");

        if (other.tag == "NameTag")
        {
            Debug.Log("Collid!");
        }

        //if (_bc.gameObject.tag.Equals("NameTag"))
        //{
        //    Debug.Log("Collid!");
        //}
    }
}
