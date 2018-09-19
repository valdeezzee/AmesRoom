using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    private SteamVR_TrackedController device;

	void Start()
    {
        device = GetComponent<SteamVR_TrackedController>();
        device.MenuButtonClicked += MenuButtonClicked;
	}

    private void Update()
    {
    }

    private void MenuButtonClicked(object sender, ClickedEventArgs e)
    {
        Debug.Log("Menu has been clicked!!!");

        //throw new System.NotImplementedException();
    }
}
