using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenRingPrefabPos : MonoBehaviour
{
   

    private int i = 0;
    private void OnCollisionEnter(Collision other)
     {
        
         if (other.gameObject.tag == "GreenStick")
         {
            
             gameObject.transform.SetParent(SpawnRings.instance.ParentObject);
             
             
         }
         
         if (other.gameObject.tag == "BlueStick" || other.gameObject.tag == "RedStick" || other.gameObject.tag == "YellowStick" || other.gameObject.tag == "StickAxisTag")
         {
             GameStartEndComtroller.GameControllStartEndInstance.isGameOver = true;
             // SpawnRings.instance.MainMusicVoice.Pause();
             // SpawnRings.instance.PointVoice.Pause();
             // SpawnRings.instance.LastPointVoice.Pause();
              // SpawnRings.instance.LoosingLevelVoice.Play();
              TinySauce.OnGameFinished(true,SpawnRings.instance.blueRingCount + SpawnRings.instance.redRingCount + SpawnRings.instance.greenRingCount + SpawnRings.instance.yellowRingCount, "1");
         }
     }

 

    private void Update()
    {
       
     
    }
    
}
