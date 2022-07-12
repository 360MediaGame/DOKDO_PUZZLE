using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearWindow : MonoBehaviour
{
    private static ClearWindow instance;

    public static ClearWindow Instance
    {
        get
        {
            return instance;
        }
    }


    public void SetWindow()
    {
        //gameObject.SetActive(true);
    }
}
