using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_level : MonoBehaviour
{
    Player player_;
    bool isButtonDown = false;
    bool stopFiring;
    [SerializeField] float firingSpeed = 1f;


    void Start()
    {
        player_ = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isButtonDown)
        {
            MakefireVariableFalse();
            player_.Fire();
        }
    }

    public void FireLaser()
    {
        stopFiring = false;
        MakefireVariableTrue();
    }
    public void StopFiring()
    {
        stopFiring = true;
        isButtonDown = false;
    }

    public void MakefireVariableTrue()
    {
        isButtonDown = true;
    }

    void MakefireVariableFalse()
    {
        isButtonDown = false;
        if (stopFiring == false)
        {
            Invoke("MakefireVariableTrue", firingSpeed);
        }
    }
}
