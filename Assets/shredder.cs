using UnityEngine;
using System.Collections;

public class shredder : MonoBehaviour {
	public GameObject[] Prefab;
	public GameObject Location;

	void Awake()
	{
		int i;
		GameObject beam;
		 i = Random.Range (0, Prefab.Length);
		beam = Instantiate(Prefab[i], new Vector3(39.65f,-2.099142f,0f), Quaternion.identity) as GameObject;
		 i = Random.Range (0, Prefab.Length);
		beam = Instantiate(Prefab[i], new Vector3(64.7f,-2.099142f,0f), Quaternion.identity) as GameObject;
	}

void OnCollisionEnter2D(Collision2D col)
{

		Destroy(col.gameObject);
		int i = Random.Range (0, Prefab.Length);
		GameObject beam = Instantiate(Prefab[i], Location.transform.position, Quaternion.identity) as GameObject;
		Debug.Log (i);
}
}
