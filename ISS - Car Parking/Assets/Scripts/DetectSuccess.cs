using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSuccess : MonoBehaviour
{
    public static bool insideBadCollider, insideBadCollider2;
    public static bool insideGoodCollider;
    public static bool success;
    // Start is called before the first frame update
    void Start()
    {
        success = false;
        insideGoodCollider = false;
        insideBadCollider = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (insideBadCollider == false && insideGoodCollider == true && insideBadCollider2 == false)
        {
            Debug.Log("SUCCESS");
            success = true;
        }
        else
        {
            success = false;
        }

    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "goodCollider")
        {
            insideGoodCollider = true;
        }
        else if (col.gameObject.tag == "badCollider1" || col.gameObject.tag == "badCollider2")
        {
            insideBadCollider = true;
        }
    }


    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "badCollider1")
        {
            insideBadCollider = false;
        }
        else if (col.gameObject.tag == "badCollider2")
        {
            insideBadCollider2 = false;
        }
        else if (col.gameObject.tag == "goodCollider")
        {
            insideGoodCollider = false;
        }
    }
}

