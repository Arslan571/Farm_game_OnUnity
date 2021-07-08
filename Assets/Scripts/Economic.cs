using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Economic : MonoBehaviour
{
    public static Economic instance = null;

    [SerializeField] Text marsiumText;

    [HideInInspector]
    public int nominalCount = 0;
    string[] nominalArray = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

    [HideInInspector]
    public float marsium = 0;

    private float marsiumReminder;
    private float marsiumNominalMax = 100;

    public float coef = 1.9f;

    public bool buyingIsTrue = false;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }


    public float CoastUpgrade(float price, float coef)
    {
        price *= coef;
        return (float)Math.Round(price, 2);
    }

    public void Buying(float price)
    {
        if (price <= marsium && (nominalCount == 0 || nominalCount > 0))
        {
            buyingIsTrue = true;

            marsium -= price;

            marsium = (float)Math.Round(marsium, 2);
            marsiumText.text = marsium.ToString() + nominalArray[nominalCount];
        }
        else if(price >= marsium && nominalCount > 0)
        {
            Debug.Log("NominalCount: " + nominalCount.ToString());
            Debug.Log("Local Marsium: " + marsium.ToString());
            Debug.Log("Total Marsium: " + (nominalCount * marsiumNominalMax) + marsium);
            Debug.Log("Total Marsium minus mainBase: " + (((nominalCount * marsiumNominalMax) + marsium) - price).ToString());
            if (price <= marsium * nominalCount * marsiumNominalMax)
            {
                buyingIsTrue = true;

                marsium = marsiumNominalMax - price;
                nominalCount--;

                marsium = (float)Math.Round(marsium, 2);
                marsiumText.text = marsium.ToString() + nominalArray[nominalCount];
            }
        }
        else
        {
            buyingIsTrue = false;
        }
    }

    public void Earning(float money)
    {
        marsium += money;
        marsium = (float)Math.Round(marsium, 2);

        MarsiumText_Update(money);
    }

  void MarsiumText_Update(float price)
    {
        if (marsium <= marsiumNominalMax)
        {
            marsium = (float)Math.Round(marsium, 2);
            marsiumText.text = marsium.ToString() + nominalArray[nominalCount];
            marsiumReminder = marsium;
        }
        else
        {
            nominalCount++;
            CalculatingNominalTransfer(price);
            marsiumText.text = marsium.ToString() + nominalArray[nominalCount];
        }
    }

    private void CalculatingNominalTransfer(float price)
    {
        marsium = price - (marsiumNominalMax - marsiumReminder);
        //marsium = marsium / 10;
        //price = price / 10;
        marsium = (float)Math.Round(marsium, 2);
    }

    public void ProgressBar()
    {
        Debug.Log("Fuck Pasha the Blonde");
    }

    
}
