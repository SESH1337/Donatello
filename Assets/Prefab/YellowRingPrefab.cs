using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowRingPrefab : MonoBehaviour
{
  

    private void OnCollisionStay(Collision other)
     {

         if (other.gameObject.tag == "YellowStick")
         {
             gameObject.transform.SetParent(SpawnRings.instance.ParentObject);
         }
         // else
         // {
         //     Time.timeScale = 0f;
         // }
         
         if (other.gameObject.tag == "GreenStick" || other.gameObject.tag == "RedStick" || other.gameObject.tag == "BlueStick" || other.gameObject.tag == "StickAxisTag")
         {
             GameStartEndComtroller.GameControllStartEndInstance.isGameOver = true;
             // SpawnRings.instance.MainMusicVoice.Pause();
             // SpawnRings.instance.PointVoice.Pause();
             // SpawnRings.instance.LastPointVoice.Pause();
             // SpawnRings.instance.LoosingLevelVoice.Play();
             TinySauce.OnGameFinished(true,SpawnRings.instance.blueRingCount + SpawnRings.instance.redRingCount + SpawnRings.instance.greenRingCount + SpawnRings.instance.yellowRingCount, "1");
         }
     }
    
}
