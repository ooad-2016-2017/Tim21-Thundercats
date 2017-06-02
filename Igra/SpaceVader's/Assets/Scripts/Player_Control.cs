using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour {

    public float speed;
    public float tilt;
    public Boundaries Boundary;

    public GameObject Shot;
    public Transform ShotzFired;

    public float fireRate;
    private float nextFire;
    
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3
            (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x , Boundary.xMin , Boundary.xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, Boundary.zMin, Boundary.zMax)
            );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * (-tilt));
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            GetComponent<AudioSource>().Play();
            nextFire = Time.time + fireRate;
            Instantiate(Shot, ShotzFired.position, ShotzFired.rotation);
        }
    }
}
[System.Serializable]
public class Boundaries
{
    public float xMin, zMin, xMax, zMax;
}
