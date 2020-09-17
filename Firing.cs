using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour {

    bool isFiring;
    bool stopFiring;

	// Use this for initialization
	void Start () {
		
	}

    public void pointerDown()
    {
        stopFiring = false;
        makeFireVariableTrue();
    }

    public void pointerUp()
    {
        isFiring = false;
        stopFiring = true;
    }

    void makeFireVariableTrue()
    {
        isFiring = true;
    }

    void makeFireVariableFalse()
    {
        isFiring = false;
        if (stopFiring == false)
        {
            Invoke("makeFireVariableTrue", 0.5f);
        }
    }

    // Update is called once per frame
    void Update () {

        if (isFiring)
        {
            makeFireVariableFalse();
            Debug.Log("Fire in hole");
        }
		
	}
}
