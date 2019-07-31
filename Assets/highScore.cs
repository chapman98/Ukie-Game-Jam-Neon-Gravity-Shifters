using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScore : MonoBehaviour {

    public SumScoreManager UpdatedHS;
    public Text HsText;

	// Use this for initialization
	void Start () {
        UpdatedHS = GetComponent<SumScoreManager>();
        HsText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        HsText.text = ("Your High Score: " + UpdatedHS);
	}
}
