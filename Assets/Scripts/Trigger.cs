using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Collider2D thing;
    public GameObject thing2;
    

    public void OnTriggerEnter2D(Collider2D obj)
    {
        //if (obj.gameObject.tag == "Player")
        //{
        // Vector3 addv = thing.transform.position;
        Instantiate(thing2, thing2.transform.position, Quaternion.identity);
        Debug.Log("Entered");
        DestroyImmediate(thing2, true);
        //}
    }

    public void Update()
    {
        OnTriggerEnter2D(thing);
    }

}

