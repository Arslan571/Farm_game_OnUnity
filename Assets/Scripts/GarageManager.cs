using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageManager : Building
{
    public static GarageManager instance;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Init()
    {
        buildName = "Garage";
    }
}
