using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class first : MonoBehaviour
{
    public second sec;

    GameObject p = GameObject.Find("GameObject");

    private void Start()
    {
        sec = p.GetComponent<second>();
    }

    public void buttonclick()
    {
        sec.fuck();
    }


}
