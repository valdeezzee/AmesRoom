﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresManager : MonoBehaviour {

    public int leftPot, middlePot, rightPot;
    public Text leftPotText, middlePotText, rightPotText;
    public int ballLimit = 10;
    public int ballCount = 0;
    private GameObject[] allBalls;
    // Use this for initialization
    void Start () {
        leftPot = middlePot = rightPot = 0;
        allBalls = GameObject.FindGameObjectsWithTag("ball");
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetValues();
        }
		
	}

    public void UpdateScore(ScorepadType pad)
    {
        switch (pad)
        {
            case ScorepadType.Left:
                leftPot++;
                leftPotText.text = leftPot.ToString();
                break;
            case ScorepadType.Middle:
                middlePot++;
                middlePotText.text = middlePot.ToString();
                break;
            case ScorepadType.Right:
                rightPot++;
                rightPotText.text = rightPot.ToString();
                break;
            default:
                break;
        }
    }

    public void Scored()
    {
        ballCount++;
        if(ballCount >= ballLimit)
        {
            foreach(GameObject ball in allBalls)
            {
                ball.SetActive(false);
            }
        }
    }

    public void ResetValues()
    {
        leftPot = middlePot = rightPot = 0;
        leftPotText.text = middlePotText.text = rightPotText.text = "0";
        ballCount = 0;
        foreach (GameObject ball in allBalls)
        {
            ball.SetActive(true);
        }
    }
}
