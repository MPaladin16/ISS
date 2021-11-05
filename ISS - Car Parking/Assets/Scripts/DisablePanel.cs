using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("disablePan", 1.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void disablePan()
    {
        this.gameObject.SetActive(false);
    }
}
