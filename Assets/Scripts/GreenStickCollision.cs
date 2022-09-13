using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

 public class GreenStickCollision : MonoBehaviour
{
   
   

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "GreenMeshCol")
        {
            SpawnRings.instance.greenRingCount++;
          
        }
        
       
    }


}



    // void CreateChildRing(Transform newParent)
    // {
    //     SpawnRings.instance.RingInstaObj.transform.SetParent(newParent);
    // }

