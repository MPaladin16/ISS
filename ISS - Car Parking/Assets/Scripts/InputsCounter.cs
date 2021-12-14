using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsCounter : MonoBehaviour
{
    public static int wCounter, sCounter, aCounter, dCounter, spaceCounter;
    private bool switcher;
    public static bool firstW;
    // Start is called before the first frame update
    void Start()
    {
        firstW = false;
        switcher = false;
        wCounter = 0;
        sCounter = 0;
        aCounter = 0;
        dCounter = 0;
        spaceCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.death == false)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown("up"))
            {
                if (switcher == false)
                {
                    if (firstW == false)
                    {
                        TimerTIme.startTime = Time.time;
                        firstW = true;
                    }
                    wCounter++;
                    switcher = true;
                    Invoke("releaseSwitcher", 0.5f);
                }
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown("down"))
            {
                if (switcher == false)
                {
                    sCounter++;
                    switcher = true;
                    Invoke("releaseSwitcher", 0.5f);
                }
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown("right"))
            {
                if (switcher == false)
                {
                    dCounter++;
                    switcher = true;
                    Invoke("releaseSwitcher", 0.5f);
                }
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown("left"))
            {
                if (switcher == false)
                {
                    aCounter++;
                    switcher = true;
                    Invoke("releaseSwitcher", 0.5f);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                if (switcher == false)
                {
                    spaceCounter++;
                    switcher = true;
                    Invoke("releaseSwitcher", 0.5f);
                }
            }
            else
            {
                switcher = false;
            }
        }
    }

    public void releaseSwitcher()
    {
        switcher = false;
    }
}
