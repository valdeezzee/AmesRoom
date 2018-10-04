using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayCollider : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.relativeVelocity.y < 0)
        {
            GetComponent<Collider>().enabled = false;
            print("OFF!");
        }            

        //print("Found: " + collisionInfo.collider.name + ", velocity: " + collisionInfo.relativeVelocity);

        //print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        //print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        //print("Their relative velocity is " + collisionInfo.relativeVelocity);
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        GetComponent<Collider>().enabled = true;
        print("ON!");
    }
}
