using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class MenuController : MonoBehaviour
{
    private SteamVR_TrackedController device;
    private Hand hand;
	void Start()
    {
        hand = GetComponent<Hand>();
	}

    private void Update()
    {
        if (hand.controller == null) return;

        if (hand.controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
            MenuButtonClicked();
    }

    private void MenuButtonClicked()
    {
        Debug.Log("Menu has been clicked!!!");
        SceneManager.LoadScene("AmesRoom_Sketchup_Joe");
        //throw new System.NotImplementedException();
    }
}
