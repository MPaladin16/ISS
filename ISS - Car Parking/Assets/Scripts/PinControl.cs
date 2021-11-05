using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinControl : MonoBehaviour
{
    public GameObject[] pins;
    private int i;
    private bool enlarge;
    private bool keyOnce;
    // Start is called before the first frame update
    void Start()
    {
        keyOnce = false;
        enlarge = false;
        i = 0;
        pins[0].SetActive(true);
        pins[1].SetActive(false);
        pins[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (keyOnce == false)
            {
                if (i == 2)
                {
                    pins[1].SetActive(false);
                    pins[2].SetActive(false);
                    pins[0].SetActive(true);

                    i = 0;


                    keyOnce = true;
                    Invoke("restartValue", 0.2f);
                }
                else
                {
                    pins[i + 1].SetActive(true);
                    pins[i].SetActive(false);

                    i++;


                    keyOnce = true;
                    Invoke("restartValue", 0.2f);
                }
            }

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {

            if (keyOnce == false)
            {
                if (i == 0)
                {
                    pins[1].SetActive(false);
                    pins[0].SetActive(false);
                    pins[2].SetActive(true);

                    i = 2;


                    keyOnce = true;
                    Invoke("restartValue", 0.2f);
                }
                else
                {
                    pins[i - 1].SetActive(true);
                    pins[i].SetActive(false);
                    i--;
                    keyOnce = true;
                    Invoke("restartValue", 0.2f);
                }
            }
        }
    }

    public void restartValue()
    {
        keyOnce = false;
    }
}
