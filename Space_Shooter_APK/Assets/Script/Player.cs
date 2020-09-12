using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //configuration parameter
    [SerializeField] float offsetY = 1f;

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
            transform.position = new Vector2(moveX, moveY);
           
        }
    }
}
