using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradingSystem : MonoBehaviour
{
    GameObject MC1;
        GameObject MC2;
    public static float Grade = 10;
    private bool w1, w2, w3, s1, s2, s3,t1,t2,t3;
    // Start is called before the first frame update
    void Start()
    {
        Grade = 10;
        MC1 = GameObject.FindGameObjectWithTag("MinusCollider1");
        MC2 = GameObject.FindGameObjectWithTag("MinusCollider2");

    }

    // Update is called once per frame
    void Update()
    {
       if( InputsCounter.wCounter > 1 && w1==false) { Grade = Grade - 0.2f; w1 = true; }
        if (InputsCounter.wCounter > 3 && w2 == false) { Grade = Grade - 0.5f; w2 = true; }
        if (InputsCounter.wCounter > 5 && w3 == false) { Grade = Grade - 0.7f; w3 = true; }
        if (InputsCounter.sCounter > 2 && s1 == false) { Grade = Grade - 0.2f; s1 = true; }
        if (InputsCounter.sCounter > 4 && s2 == false) { Grade = Grade - 0.5f; s2 = true; }
        if (InputsCounter.sCounter > 6 && s3 == false) { Grade = Grade - 0.8f; s3 = true; }

        if (TimerTIme.passedTime > 30 && t1==false) { Grade = Grade - 0.4f; t1 = true; }
        if (TimerTIme.passedTime > 45 && t2 == false) { Grade = Grade - 0.8f; t2 = true; }
        if (TimerTIme.passedTime > 65 && t3 == false) { Grade = Grade - 1.4f; t3 = true; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MinusCollider1") {
            Grade = Grade - 0.5f;
        }
        if (other.gameObject.tag == "MinusCollider2")
        {
            Grade = Grade - 0.5f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MinusCollider1")
        {
            Grade = Grade + 0.5f;
        }
        if (other.gameObject.tag == "MinusCollider2")
        {
            Grade = Grade + 0.5f;
        }
    }
}
