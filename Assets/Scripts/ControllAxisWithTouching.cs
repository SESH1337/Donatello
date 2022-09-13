using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllAxisWithTouching : MonoBehaviour
{
  
    // Touch Script;
    
    private Touch touch;
    private Vector3 touchPosition;
    private Quaternion rotationY;
    public float RotationSpeed = 13.0f;
    void Start()
    {
        
    }
    
    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
                
            {
                // rotationY = Quaternion.Euler(0f, Mathf.Lerp(-touch.deltaPosition.x * RotationSpeed * Time.deltaTime,touch.deltaPosition.x * RotationSpeed * Time.deltaTime,0), 0);
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * RotationSpeed * Time.deltaTime, 0);
                transform.rotation = rotationY * transform.rotation;
            }
        }
    }
}
