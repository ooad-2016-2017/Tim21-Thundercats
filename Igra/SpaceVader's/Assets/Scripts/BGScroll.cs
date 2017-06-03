using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour {

    public float ScrollSpeed;
    public float TileSizeAxY;

    private Vector3 StartPos;

	// Use this for initialization
	void Start ()
    {
        StartPos = transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
        float newposition = Mathf.Repeat(Time.time * ScrollSpeed,TileSizeAxY);
        transform.position = StartPos + Vector3.forward * newposition;
	}
}
