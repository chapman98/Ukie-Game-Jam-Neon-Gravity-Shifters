using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraWork : MonoBehaviour {
    public Vector3 pos;
    //float diffY;
    //GameObject player;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 0) {
            transform.Translate(0, -transform.position.y, 0);
        } else if (transform.position.y < 0) {
            transform.Translate(0, -transform.position.y, 0);
        }
	}
}
