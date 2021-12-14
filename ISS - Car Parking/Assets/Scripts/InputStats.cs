using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputStats : MonoBehaviour
{
    public GameObject mf, mb, mr, ml, hu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mf.gameObject.GetComponent<Text>().text = (InputsCounter.wCounter.ToString()) + " " + "times";
        mb.gameObject.GetComponent<Text>().text = (InputsCounter.sCounter.ToString()) + " " + "times";
        mr.gameObject.GetComponent<Text>().text = (InputsCounter.dCounter.ToString()) + " " + "times";
        ml.gameObject.GetComponent<Text>().text = (InputsCounter.aCounter.ToString()) + " " + "times";
        hu.gameObject.GetComponent<Text>().text = (InputsCounter.spaceCounter.ToString()) + " " + "times";
    }
}
