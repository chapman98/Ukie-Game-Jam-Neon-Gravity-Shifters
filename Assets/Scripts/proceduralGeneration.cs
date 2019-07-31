using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralGeneration : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {
        prefab = FindObjectOfType<GameObject>();
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        Instantiate(prefab, position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
