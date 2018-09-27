using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class MenuController : MonoBehaviour
{
    private SteamVR_Controller.Device device;
    private Hand hand;
    void Start()
    {
        hand = GetComponent<Hand>();
    }

    private void Update()
    {
        if (hand.controller == null) return;
        device = SteamVR_Controller.Input((int)hand.controller.index);

        if (hand.controller.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
            MenuButtonClicked();
        else if (hand.controller.GetPress(SteamVR_Controller.ButtonMask.Trigger) &&
                hand.controller.GetTouchDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Vector2 touchPad = (device.GetAxis(EVRButtonId.k_EButton_SteamVR_Touchpad));

            if (touchPad.y > 0.7f)
            {
                print("scale up");
                RoomProperties.instance.SetRoomScale("ScaleUp");
            }
            else if (touchPad.y < 0.3f)
            {
                print("scale down");
                RoomProperties.instance.SetRoomScale("ScaleDown");
            }
        }
    }

    private void MenuButtonClicked()
    {
        Debug.Log("Menu has been clicked!!!");
        SceneManager.LoadScene("AmesRoom_Sketchup_Joe");
        //throw new System.NotImplementedException();
    }
}
