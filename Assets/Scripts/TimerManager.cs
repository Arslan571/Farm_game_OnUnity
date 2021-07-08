using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public GameObject spObj;
    public SolarPanelManager sp;

    public Mesh spMesh;

    public float timeRemaning;
    public float timerMax = 2;

    private void Start()
    {
        sp = spObj.GetComponent<SolarPanelManager>();
        spMesh = spObj.GetComponent<Mesh>();
    }

    private void Update()
    {
        
    

    }

    float CalculateSliderValue()
    {
        return (timeRemaning / timerMax);
    }
}
