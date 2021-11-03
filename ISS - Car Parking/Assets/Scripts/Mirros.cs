using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirros : MonoBehaviour
{
    private bool insideLeft, insideNormal, insideRight, insideInner;
    public GameObject camera;
    public GameObject leftPos, rightPos, normalPos, innerPos;
    // Start is called before the first frame update
    void Start()
    {
        InitializeConditions();
        camera.transform.position = normalPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {

            if (insideLeft == true && insideNormal == false)
            {
                camera.transform.position = normalPos.transform.position;
                camera.transform.rotation = normalPos.transform.rotation;
                insideLeft = false;
                insideNormal = true;
                insideRight = false;
                insideInner = false;
            }
            else if (insideLeft == false && (insideNormal == true || insideInner == true || insideRight == true))
            {
                camera.transform.position = leftPos.transform.position;
                camera.transform.rotation = leftPos.transform.rotation;
                insideLeft = true;
                insideNormal = false;
                insideRight = false;
                insideInner = false;
            }
        }
        else if (Input.GetKeyDown("2"))
        {

            if (insideRight == true && insideNormal == false)
            {
                camera.transform.position = normalPos.transform.position;
                camera.transform.rotation = normalPos.transform.rotation;
                insideRight = false;
                insideNormal = true;
                insideLeft = false;
                insideInner = false;

            }
            else if (insideRight == false && (insideNormal == true || insideLeft == true || insideInner == true))
            {
                camera.transform.position = rightPos.transform.position;
                camera.transform.rotation = rightPos.transform.rotation;
                insideRight = true;
                insideNormal = false;
                insideLeft = false;
                insideInner = false;
            }
        }
        else if (Input.GetKeyDown("3"))
        {

            if (insideInner == true && insideNormal == false)
            {
                camera.transform.position = normalPos.transform.position;
                camera.transform.rotation = normalPos.transform.rotation;
                insideRight = false;
                insideNormal = true;
                insideLeft = false;
                insideInner = false;
            }
            else if (insideInner == false && (insideNormal == true || insideLeft == true || insideRight == true))
            {
                camera.transform.position = innerPos.transform.position;
                camera.transform.rotation = innerPos.transform.rotation;
                insideRight = false;
                insideNormal = false;
                insideLeft = false;
                insideInner = true;
            }
        }
    }

    public void InitializeConditions()
    {
        insideInner = false;
        insideLeft = false;
        insideNormal = true;
        insideRight = false;
    }

}
