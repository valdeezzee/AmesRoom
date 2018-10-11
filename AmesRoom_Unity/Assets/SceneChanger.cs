using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SceneChanger : MonoBehaviour
{
    // TODO: MAKE A SINGLETON
    private int sceneIndex = 0;
    public List<string> sceneNames = new List<string>();
    public List<GameObject> pots = new List<GameObject>();
    
    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            SwitchPots();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sceneIndex--;
            ChangeScene();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sceneIndex++;
            ChangeScene();
        }
    }

    private void SwitchPots()
    {
        if (pots.Count == 0)
            return;
        foreach (GameObject pot in pots)
        {
            pot.SetActive(!pot.activeSelf);
        }
        ScoresManager scoresManager = FindObjectOfType<ScoresManager>();
        if (scoresManager != null)
        {
            scoresManager.ResetValues();
            print("Values reset");
        }
    }

    private void ChangeScene()
    {
        sceneIndex = Mathf.Clamp(sceneIndex, 0, sceneNames.Count - 1);
        SceneManager.LoadScene(sceneNames[sceneIndex]);
    }
}
