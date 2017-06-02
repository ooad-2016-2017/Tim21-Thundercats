using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timed_Destruction : MonoBehaviour {

    public float HalfLife;
	void Start ()
    {
        Destroy(gameObject, HalfLife);
	}
	
	
}
