using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestEconomics : MonoBehaviour
{
    [SerializeField] Text marsiumText;
    [SerializeField] Text marsiumCountText;
    [SerializeField] Text deductibleText;

    public float deductible;
    float remains;

    float textValue = 0;
    float textValueMax  = 10;
    int testCount = 0;

    string[] nominalArray = {"test", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", };

    private void Start()
    {
        marsiumText.text = "Marsium : 0";
        marsiumCountText.text = "Marsium count : 0";

        deductibleText.text = "Deductible : " + deductible.ToString();
    }

    public void TestClick()
    {
        if (textValue < textValueMax)
        {
            textValue++;

            if (testCount == 0)
            {
                
                marsiumText.text = "Marsium : " + textValue.ToString();
            }
            else
            {
                marsiumText.text = "Marsium : " + textValue.ToString() + nominalArray[testCount];
            }
        }
        else
        {
            textValue = 1;
            testCount++;
            marsiumCountText.text = "Marsium count: " + testCount.ToString(); 

            marsiumText.text = textValue.ToString() + nominalArray[testCount];
        }
    }
}
