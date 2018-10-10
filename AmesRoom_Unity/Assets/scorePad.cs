using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorePad : MonoBehaviour {
    public enum ScorepadType { Left, Middle, Right};

    public ScorepadType pad;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
