using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTheEngine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (DetectSuccess.success == true && Health.death == false)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

    }
}
