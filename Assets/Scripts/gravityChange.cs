using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityChange : MonoBehaviour
{
    //Gravity value
    public float grav ;
    //If gravity is flipped
    public bool flipped = false ;
    DrawLine mDL;
    TestMusicTrigger muse;

	// Use this for initialization
	void Start ()
    {
        //Gets the gravity component
        grav = GetComponent<Rigidbody2D>().gravityScale;
        mDL = GetComponent<DrawLine>();
        muse = GetComponent<TestMusicTrigger>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            flipped = true;
            if(mDL!=null) mDL.AddPoint(transform.position);
        }
        else
        {
            if (mDL != null) mDL.Updatelastpoint(transform.position);
        }
        if (flipped == true)
        {
            Rotate();
            grav *= -1 ;
            flipped = false ;
            muse.playSound();
        } //Changes the gravity value based on if the player is flipped
        GetComponent<Rigidbody2D>().gravityScale = grav;
	}
    
    void Rotate()
    {
        transform.Rotate(Vector3.left * -180);
    }
    
}
