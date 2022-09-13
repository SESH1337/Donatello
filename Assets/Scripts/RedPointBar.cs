using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class RedPointBar : MonoBehaviour
{

    public static RedPointBar instance;

   
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

    [SerializeField] private RectTransform Holder;
    [SerializeField] private Image circleImage;
    [SerializeField] private Text textProgress;

    [SerializeField] [Range(0, 1)] public float progress = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        circleImage.fillAmount = progress;
        textProgress.text = Mathf.Floor(progress * 100).ToString() + "%";
        Holder.rotation = Quaternion.Euler(new Vector3(0,0,- progress * 360));
    }
}
