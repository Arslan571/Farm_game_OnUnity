using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarPanelManager : Building
{
    public static SolarPanelManager instance = null;
    
    public GameObject spStadia1;
    public GameObject spStadia2;
    public GameObject spStadia3;
    public GameObject spStadia4;
    
    public float timeRemaning;
    public float timerMax = 2;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance == this)
        {
            Destroy(gameObject);
        }

        //DontDestroyOnLoad(gameObject);

        InitSPComponents();
    }

    private void Update()
    {
        MainClick();
    }

    private void InitSPComponents()
    {
        buildName = "SolarPanel";

        SolarPanelInit();
    }

    public void SolarPanelInit()
    {
        spStadia1.SetActive(true);
        spStadia2.SetActive(false);
        spStadia3.SetActive(false);
        spStadia4.SetActive(false);
    }

    public override void StadiaUpgrade()
    {
        if (level == 0)
        {
            spStadia1.SetActive(true);
            level++;

        } else if (level == 1)
        {
            spStadia2.SetActive(true);
            level++;

        } else if (level == 2)
        {
            spStadia3.SetActive(true);
            level++;

        }else if(level == 3)
        {
            spStadia4.SetActive(true);
            level++;
        }
    }
}
