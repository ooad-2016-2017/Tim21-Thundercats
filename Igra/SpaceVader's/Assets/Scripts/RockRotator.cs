using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockRotator : MonoBehaviour {

    public float tumble;

    private void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}
