using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePointerDownRight : MonoBehaviour
{

    private float speed = 200;
    private bool isRotatingRight;
  
   
   

    private void Update()
    {
    
        if (isRotatingRight)
        {
            RotateAxisToRight();
        }
   
    }

    // ButtonScript;

  
    public void pointerDownRight()
    {
        isRotatingRight = true;
    }
    
    public void pointerUpRight()
    {
        isRotatingRight = false;
    }
    
 
    public void RotateAxisToRight()
    {
        transform.Rotate(0,  -speed * Time.deltaTime, 0);
     
    }





}
