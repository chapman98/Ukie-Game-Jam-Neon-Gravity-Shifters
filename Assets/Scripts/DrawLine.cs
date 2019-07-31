using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    LineRenderer mLine;

    Vector3[] mPositions;

    // Use this for initialization
    void Start() {
        mLine = gameObject.AddComponent<LineRenderer>();
        mLine.material = new Material(Shader.Find("Sprites/Default"));
        mLine.widthMultiplier = 0.2f;
        mPositions = new Vector3[10];
        mLine.positionCount = mPositions.Length;
    }

    public void AddPoint(Vector3 vPosition)
    {
        for (int i=1; i<mPositions.Length; i++)
        {
            mPositions[i - 1] = mPositions[i];
        }
        mPositions[mPositions.Length - 1] = vPosition;
        mLine.SetPositions(mPositions);
    }
    public void Updatelastpoint(Vector3 vPoint)
    {
        mLine.SetPosition(mPositions.Length-1,vPoint);
    }


}
