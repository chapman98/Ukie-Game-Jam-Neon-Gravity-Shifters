using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour {
    public GameObject pobj;
    //public GameObject gobj;
    //public GameObject[] preF;
    //public AudioSource GamePlaySound;
    //public GameObject tobj;
    public void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("enter");
        //GamePlaySound.Play();
        //Vector3 position = GetPosition(collision);
        if (collision.gameObject.tag == "Player") {
            Debug.Log("enter");
            GameObject player = GameObject.FindWithTag("Player");
            Destroy(player);
        }
        //Instantiate(pobj, new Vector3(0, 0, 0), Quaternion.identity);
        //int arrayposition = Random.Range(0, preF.Length);
        //Instantiate(preF[arrayposition], new Vector3(3, 0, 0) + this.transform.position, Quaternion.identity);
        //Instantiate(this, new Vector3(6, -1, 0) + this.transform.position, Quaternion.identity);
    }


}
