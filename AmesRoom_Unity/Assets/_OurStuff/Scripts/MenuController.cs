using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace AmesScripts
{
    public class MenuController : MonoBehaviour
    {
        private SteamVR_Controller.Device device;
        private Hand hand;
        public bool allowScale = false;
        public string onlineScene { get; set; }
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
                    hand.controller.GetTouchDown(SteamVR_Controller.ButtonMask.Touchpad) && allowScale)
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}