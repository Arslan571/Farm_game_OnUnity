using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TestSmartScore : MonoBehaviour
{
   public Text marsiumText;
   public Text calculateText;

    float marsium = 0;
    public float money = 0.5f;



    string[] nominalArray = {"a", "b", "c", "d", "c"};

    int nominalCount = 0;

    float marsiumReminder;

    float marsiumNominalLimit = 5;


    private void Start()
    {
        MarsiumText_Update();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Earning();
            MarsiumText_Update();
        }
    }

    void Earning()
    {
        marsium = marsium + money;
    }

    void MarsiumText_Update()
    {
        if (marsium <= marsiumNominalLimit)
        {
            marsium = (float)Math.Round(marsium, 2);
            marsiumText.text = marsium.ToString() + nominalArray[nominalCount];
            marsiumReminder = marsium;
        }
        else
        {
            nominalCount++;
            CalculatingNominalTransfer();
            marsiumText.text = marsium.ToString() + nominalArray[nominalCount];
            CalculatingVisualizer();
        }
    }

    void CalculatingNominalTransfer()
    {
        marsium = money - (marsiumNominalLimit - marsiumReminder);
        //marsium = marsium / 10;
        money = money / 10;
        marsium = (float)Math.Round(marsium, 2);
    }

    void CalculatingVisualizer()
    {
        calculateText.text = money.ToString() + " - " + "( " + marsiumNominalLimit.ToString() + " - " + marsiumReminder.ToString()+ ") = " + marsium.ToString();
    }
}
