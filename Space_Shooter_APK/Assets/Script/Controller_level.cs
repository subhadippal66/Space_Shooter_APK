using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_level : MonoBehaviour
{
    Player player_;


    void Start()
    {
        player_ = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireLaser()
    {
        player_.Fire();
    }
}
