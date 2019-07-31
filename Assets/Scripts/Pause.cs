using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    GameObject[] pause;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        pause = GameObject.FindGameObjectsWithTag("pause");
        hidePaused();
    }

    // Update is called once per frame
    void Update()
    {
        //uses the p button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                hidePaused();
            }

        }
    }

    public void showPaused()
    {
        foreach (GameObject g in pause)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pause)
        {
            g.SetActive(false);
        }
    }

}
