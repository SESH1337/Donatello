using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePointerDownLeft : MonoBehaviour
{
    private float speed = 200;
    private bool isRotatingLeft;
  
    private bool isRotatingRight;
   

    private void Update()
    {
    
        if (isRotatingLeft)
        {
            RotateAxisToLeft();
        }
   
    }

    // ButtonScript;

  
    public void pointerDownLeft()
    {
        isRotatingLeft = true;
    }
    
    public void pointerUpLeft()
    {
        isRotatingLeft = false;
    }
    
 
    public void RotateAxisToLeft()
    {
      
        
        transform.Rotate(0,  speed * Time.deltaTime , 0);
     
    }
    

    
 
    
    
    
    
    
    // Touch Script;
    
    // private Touch touch;
    // private Vector3 touchPosition;
    // private Quaternion rotationY;
    // public float RotationSpeed;
    // void Start()
    // {
    //     
    // }
    //
    //
    // void Update()
    // {
    //     if (Input.touchCount > 0)
    //     {
    //         touch = Input.GetTouch(0);
    //         if (touch.phase == TouchPhase.Moved)
    //         {
    //             // rotationY = Quaternion.Euler(0f, Mathf.Lerp(-touch.deltaPosition.x * RotationSpeed * Time.deltaTime,touch.deltaPosition.x * RotationSpeed * Time.deltaTime,0), 0);
    //             rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * RotationSpeed * Time.deltaTime, 0);
    //             transform.rotation = rotationY * transform.rotation;
    //         }
    //     }
    // }
}
