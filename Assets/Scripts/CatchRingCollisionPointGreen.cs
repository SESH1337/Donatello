using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchRingCollisionPointGreen : MonoBehaviour
{
    public GameObject PointEffect;
    public GameObject PointEffect2;
  

    
  
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenMeshCol")
        {
           
            // Debug.Log(redRingCount +"wadaw");
            SpawnRings.instance.greenRingCount++;
            GreenPointBar.instance.progress += 0.20f;
          
            if (SpawnRings.instance.greenRingCount <= 4)
            {
                SpawnRings.instance.PointVoice.Play();    
            }else if (SpawnRings.instance.greenRingCount <= 5)
            {
                SpawnRings.instance.LastPointVoice.Play();    
                PointEffect.SetActive(true);
                PointEffect2.SetActive(true);
                SpawnRings.instance.ringThrowSpeed -= 300;
            }
        }
    }
}
