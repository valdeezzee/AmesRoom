using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    private Vector3 originalPosition;
    private ScoresManager scoresManager;
    // Use this for initialization
    void Start () {
        
        originalPosition = transform.parent.position;
        scoresManager = FindObjectOfType<ScoresManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "floor")
        {
            ResetBall();
            scoresManager.Scored();
        }
        if (other.tag == "floorReset")
        {
            ResetBall();
        }
    }

    public void ResetBall()
    {
        Rigidbody rigidBody = transform.parent.GetComponent<Rigidbody>();
        rigidBody.isKinematic = true;
        transform.parent.position = originalPosition;
        rigidBody.isKinematic = false;

    }
}
