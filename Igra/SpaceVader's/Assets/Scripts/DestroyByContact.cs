using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject PlayerExplosion;
    private Game_Master GameMaster;
    public int ScoreVal;

    private void Start()
    {
        GameObject TargetMaster = GameObject.FindWithTag("GameController");
        if(TargetMaster != null)
        {
            GameMaster = TargetMaster.GetComponent<Game_Master>();
        }
        if(GameMaster == null)
        {
            Debug.Log("Cannot find active object Game Control , or cannot find active script Game_Master within the object Game Control");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Border")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);
            GameMaster.GameOverMan();
        }
        GameMaster.AddScore(ScoreVal);
        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }
}
