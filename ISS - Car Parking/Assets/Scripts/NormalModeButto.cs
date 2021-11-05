using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalModeButto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeScene()
    {
        GameObject.FindGameObjectWithTag("closingPanel").gameObject.GetComponent<Animator>().Play("menuEnding");
        Invoke("changeItLater", 1.2f);
    }

    public void changeItLater()
    {
        SceneManager.LoadScene("Parking Simulator");
    }
}
