using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideStoperica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Health.death == false)
        {
            GameObject.FindGameObjectWithTag("stopericaPanel").gameObject.SetActive(true);
        }
    }
}
