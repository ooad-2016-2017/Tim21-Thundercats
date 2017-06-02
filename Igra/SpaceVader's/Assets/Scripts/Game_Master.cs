using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Master : MonoBehaviour {

    public GameObject Hazard;
    public Vector3 SpawnVal;
    public int HazardCount;
    public float SpawnHold;
    public float StartingWait;
    public float WaveHold;

    public GUIText ScoreText;
    public GUIText RestartText;
    public GUIText GameOverText;
    private int CurrentScore;

    private bool GameOver;
    private bool Reset;

    private void Start()
    {
        GameOver = false;
        GameOverText.text = "";
        Reset = false;
        RestartText.text = "";
        CurrentScore = 0;
        UpdateScore();
        StartCoroutine(SpawnVawe());
    }

    private void Update()
    {
        if(Reset)
        {
            if(Input.GetKeyDown (KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    IEnumerator SpawnVawe ()
    {
        yield return new WaitForSeconds(StartingWait);
        while (true)
        {
            for (int i = 0; i < HazardCount; i++)
            {
                Vector3 SpawnPos = new Vector3(Random.Range(-SpawnVal.x, SpawnVal.x), SpawnVal.y, SpawnVal.z);
                Quaternion SpawnRot = Quaternion.identity;
                Instantiate(Hazard, SpawnPos, SpawnRot);
                yield return new WaitForSeconds(SpawnHold);
            }
            yield return new WaitForSeconds(WaveHold);

            if(GameOver)
            {
                RestartText.text = "Press 'R' for Restart";
                Reset = true;
                break;
            }
        }
    }

    public void AddScore(int val)
    {
        CurrentScore += val;
        UpdateScore();
    }

     void UpdateScore()
    {
        ScoreText.text = "Score: " + CurrentScore;
    }

    public void GameOverMan()
    {
        GameOverText.text = "Game Over";
        GameOver = true;
    }
}
