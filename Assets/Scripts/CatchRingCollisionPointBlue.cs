using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchRingCollisionPointBlue : MonoBehaviour
{
    
    public GameObject PointEffect;
    public GameObject PointEffect2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlueMeshCol")
        {
           
            // Debug.Log(redRingCount +"wadaw");
            SpawnRings.instance.blueRingCount++;
              BluePointBar.instance.progress += 0.20f;
              if (SpawnRings.instance.blueRingCount <= 4)
              {
                  SpawnRings.instance.PointVoice.Play();    
              }else if (SpawnRings.instance.blueRingCount <= 5)
              {
                  SpawnRings.instance.LastPointVoice.Play();    
                  PointEffect.SetActive(true);
                  PointEffect2.SetActive(true);
                  SpawnRings.instance.ringThrowSpeed -= 300;
              }
              
        }
    }
}
