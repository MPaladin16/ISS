using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashOrFinished : MonoBehaviour
{
    public string LevelToLoad = "";
    // Start is called before the first frame update
    void Start()
    {
        if (LevelToLoad == "") // default to current scene 
        {
            LevelToLoad = Application.loadedLevelName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (InputsCounter.enterPressed == true)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 1;
                InputsCounter.firstW = false;

                Application.LoadLevel(LevelToLoad);
            }
            if (Input.GetKeyDown("m"))
            {
                Time.timeScale = 1;

                SceneManager.LoadScene("Menu");
            }
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
