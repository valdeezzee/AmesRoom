using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomProperties : MonoBehaviour {

    public static RoomProperties instance;
    public Transform playerCamera;
    public float scaleValue = 1.5f;
	// Use this for initialization
	void Start () {

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetRoomScale(string scaling)
    {
        switch (scaling)
        {
            case "ScaleUp":
                transform.localScale *= scaleValue;
                break;
            case "ScaleDown":
                transform.localScale /= scaleValue;
                break;
            default:
                break;
        }

        //SetRoomLocation();
    }

    public void SetRoomLocation()
    {
        transform.position = new Vector3(playerCamera.position.x, playerCamera.position.y, .8f - .5f);
    }
}
