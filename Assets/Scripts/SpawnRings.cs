using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class SpawnRings : MonoBehaviour
{
    public int currentRingIndex;

    public static SpawnRings instance;

    public GameObject[] stickAxis;
    public GameObject[] rings;
    public GameObject RingInstaObj;
    public Transform ParentObject;
    public Transform outSceneRings;
    public AudioSource MainMusicVoice;
    public AudioSource PointVoice;
    public AudioSource LastPointVoice;
    public AudioSource LoosingLevelVoice;
    public AudioSource WinVoice;
    public int ringThrowSpeed;
    public GameObject WinnerUIParticles;
    public GameObject[] WinnerUIFLareParticle;
    public GameObject WinMenuUI;
    private bool isSetActiveRed = true;
    private bool isSetActiveBlue= true;
    bool isSetActiveGreen = true;
    bool isSetActiveYellow = true;
  

    public int redRingCount, blueRingCount, yellowRingCount,greenRingCount;
 
    
    public int i = 0;

    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        i++;
        if (i > ringThrowSpeed)
        {
           
            RingInstaObj = Instantiate(rings[Random.Range(0,rings.Length)], transform.position, Quaternion.Euler(-90, 0, 0));
            
            // CreateChildRing(ParentObject);
            i = 0;
        }


        if (redRingCount == 5)
        {
            rings[2].SetActive(false);
            isSetActiveRed = false;
            
        }
        if (greenRingCount == 5)
        {
            rings[1].SetActive(false);
            isSetActiveGreen = false;
          
        }
        if (blueRingCount == 5)
        {
            rings[0].SetActive(false);
            isSetActiveBlue = false;
            
        }
        if (yellowRingCount == 5)
        {
            rings[3].SetActive(false);
            
            isSetActiveYellow = false;
        }

        if (isSetActiveYellow == false && isSetActiveRed == false & isSetActiveBlue == false & isSetActiveGreen == false)
        {
            PointVoice.Pause();
            MainMusicVoice.Pause();
            WinnerUIParticles.SetActive(true);
            for (int j = 0; j < WinnerUIFLareParticle.Length; j++)
            {
                WinnerUIFLareParticle[i].SetActive(true);
            }
            WinMenuUI.SetActive(true);
            GameStartEndComtroller.GameControllStartEndInstance.SettingButton.SetActive(false);
            // WinVoice.Play();
            // Debug.Log("Hell Yeah");
        }
        
    }
    
    // void CreateChildRing(Transform newParent)
    // {
    //     RingInstaObj.transform.SetParent(newParent);
    // }
    //

}
