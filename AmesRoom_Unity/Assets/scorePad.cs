using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePad : MonoBehaviour
{   

    public ScorepadType pad;
    private ScoresManager scoresManager;

    // Use this for initialization
    void Start()
    {
        scoresManager = FindObjectOfType<ScoresManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ball")
        {
            scoresManager.UpdateScore(pad);
            Respawn ball = other.GetComponent<Respawn>();
            if (ball != null)
                ball.ResetBall();
        }
    }
}

public enum ScorepadType { Left, Middle, Right };