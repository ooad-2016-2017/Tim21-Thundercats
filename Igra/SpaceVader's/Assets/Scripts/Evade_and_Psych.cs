using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evade_and_Psych : MonoBehaviour {

    public Vector2 WaitForIt;
    public Vector2 ManeuverTime;
    public Vector2 ManeuverHold;
    public float Dodge;
    public float Compensate;
    public float Tilt;
    public Boundaries Border;

    private float CurrentSpeed;
    private float Maneuver;
    private Rigidbody Body;

	void Start ()
    {
        Body = GetComponent<Rigidbody>();
        CurrentSpeed = Body.velocity.z;
        StartCoroutine(Evade());
	}
	
    IEnumerator Evade ()
    {
        yield return new WaitForSeconds(Random.Range(WaitForIt.x, WaitForIt.y));

        while (true)
        {
            Maneuver = Random.Range(1.5f,Dodge) * -Mathf.Sign(transform.position.x) ;
            yield return new WaitForSeconds(Random.Range(ManeuverTime.x,ManeuverTime.y));
            Maneuver = 0;
            yield return new WaitForSeconds(Random.Range(ManeuverHold.x,ManeuverHold.y));
        }

    }

	void FixedUpdate ()
    {
        float NextManeuver = Mathf.MoveTowards(Body.velocity.x, Maneuver, Time.deltaTime * Compensate);
        Body.velocity = new Vector3(NextManeuver, 0.0f, CurrentSpeed);
        //Body.velocity = new Vector3(NextManeuver, 0.0f, Body.velocity.z);
        Body.position = new Vector3
            (
            Mathf.Clamp(Body.position.x, Border.xMin, Border.xMax),
            0.0f,
            Mathf.Clamp(Body.position.z, Border.zMin, Border.zMax)
            );
        Body.rotation = Quaternion.Euler(0.0f, 0.0f, Body.velocity.x * (-Tilt));
    }
}
