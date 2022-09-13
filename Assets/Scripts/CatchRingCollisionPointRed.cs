﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchRingCollisionPointRed : MonoBehaviour
{
    public GameObject PointEffect;
    public GameObject PointEffect2;
  


    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedMeshCol")
        {
            
            // Debug.Log(redRingCount +"wadaw");
            SpawnRings.instance.redRingCount++;
            RedPointBar.instance.progress += 0.20f;
            if (SpawnRings.instance.redRingCount <= 4)
            {
                SpawnRings.instance.PointVoice.Play();    
            }else if (SpawnRings.instance.redRingCount <= 5)
            {
                SpawnRings.instance.LastPointVoice.Play();    
                PointEffect.SetActive(true);
                PointEffect2.SetActive(true);
                SpawnRings.instance.ringThrowSpeed -= 300;
            }
       
        }
    }
}
