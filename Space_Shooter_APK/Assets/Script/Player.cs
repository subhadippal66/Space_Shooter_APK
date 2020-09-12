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
        if(Input.touchCount>0)
        {
            
            Touch touch = Input.GetTouch(0);
            Camera gameCamera = Camera.main;

            var moveX = gameCamera.ScreenToWorldPoint(touch.position).x;
            var moveY = gameCamera.ScreenToWorldPoint(touch.position).y + offsetY;
            transform.position = new Vector2(moveX, moveY);
           
        }
    }
}
