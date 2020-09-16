using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_level : MonoBehaviour
{
    Player player_;
    bool isButtonDown = false;


    void Start()
    {
        player_ = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isButtonDown)
        {
            player_.Fire();
        }
    }

    public void FireLaser()
    {
        isButtonDown = true;
    }
    public void StopFiring()
    {
        isButtonDown = false;
    }
}
