using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //configuration parameter
    [SerializeField] float offsetY = 1f;
    [SerializeField] GameObject laserPlayer;
    [SerializeField] float fireRate = 1f;
    [SerializeField] float yOffsetoflaser;


    bool isPressedFire;

    void Start()
    {
       
      
    }

   
    void Update()
    {
        Move();       
    }

   
    void Move()
    {
        if(Input.touchCount>0)  //checks if the we touches the screen
        {
            
            Touch touch = Input.GetTouch(0); //zero is for the 1st screen touch.
            Camera gameCamera = Camera.main;

            var moveX = gameCamera.ScreenToWorldPoint(touch.position).x;
            var moveY = gameCamera.ScreenToWorldPoint(touch.position).y + offsetY; 
            //offset is for visibility of player ship
            transform.position = new Vector3(moveX, moveY,-1f);
            
           
        }
    }

    public void Fire()
    {
        if (Input.touchCount>1)
        {
            Vector3 laserPos = new Vector3(transform.position.x, transform.position.y + yOffsetoflaser, transform.position.z);
            GameObject laser_001 = Instantiate(laserPlayer, laserPos, Quaternion.identity) as GameObject;
            laser_001.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, fireRate);
        }
    }
}
