using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyPlayer : MonoBehaviour {
    SumScoreExample phun;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Die Player!");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Die Player!");
            //string endn = "Scene1";
            SceneManager.LoadScene("End Screen", LoadSceneMode.Additive);
            GameObject player = GameObject.FindWithTag("Player");
            Destroy(player);
            phun.ToggleTimed();
            //Application.LoadLevel("End Screen");
            
            //GameObject cam = GameObject.FindWithTag("MainCamera");
            //cam.transform.position = new Vector3(0,0,0);

        }
    }
}
