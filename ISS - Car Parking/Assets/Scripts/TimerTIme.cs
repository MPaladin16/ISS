using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTIme : MonoBehaviour
{
    public static float startTime;
    public static float passedTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Health.death == false && InputsCounter.firstW == true)
        {
            passedTime = Time.time - startTime;
            this.gameObject.GetComponent<Text>().text = (passedTime).ToString("F2");
        }

    }
}
