using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyFireControl : MonoBehaviour {

    public GameObject Bullet;
    public Transform SpawnBullet;
    public float FireRate;
    public float BelayThat;

    private AudioSource Sound;

	void Start ()
    {
        Sound = GetComponent<AudioSource>();
        InvokeRepeating("FireAway", BelayThat, Random.Range(1,FireRate));
	}

    void FireAway()
    {
        Instantiate(Bullet, SpawnBullet.position, SpawnBullet.rotation);
        Sound.Play();
    }	
	
}
