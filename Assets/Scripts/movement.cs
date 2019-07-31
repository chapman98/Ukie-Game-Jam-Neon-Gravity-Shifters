    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject thing;
    // The speed of the Object
    public float speed;
    // Is it right or left
    public bool right;

    void FixedUpdate()
    {
        if (right == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

}