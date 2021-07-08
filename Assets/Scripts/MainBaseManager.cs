using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBaseManager : Building
{
    public static MainBaseManager instance = null;

    public GameObject mbStadiaRoom1;
    public GameObject mbStadiaRoom2;
    public GameObject mbStadiaRoom3;
    public GameObject mbStadiaRoom4;
    public GameObject mbStadiaRoom5;
    public GameObject mbStadiaRoom6;
    public GameObject mbStadiaRoom7;
    public GameObject mbStadiaRoom8;
    public GameObject mbStadiaGarden;
    public GameObject mbStadiaGarage;

    public GameObject connector1;
    public GameObject connector2;
    public GameObject connector3;

    public float money = 1;

    [SerializeField] Button BaseUpgradeButton;

    private void Start()
    {
        buildName = "MainBase";

        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        InitComponentsMB();

        InitBuildMB();
    }

    private void InitComponentsMB()
    {

    }

    private void Update()
    {

        MainClick();
    
    }

    public void InitBuildMB()
    {
        //mbStadiaMain.SetActive(true);
        connector1.SetActive(false);
        connector2.SetActive(false);
        connector3.SetActive(false);
        mbStadiaRoom1.SetActive(false);
        mbStadiaRoom2.SetActive(false);
        mbStadiaRoom3.SetActive(false);
        mbStadiaRoom4.SetActive(false);
        mbStadiaRoom5.SetActive(false);
        mbStadiaRoom6.SetActive(false);
        mbStadiaRoom7.SetActive(false);
        mbStadiaRoom8.SetActive(false);
        mbStadiaGarden.SetActive(false);
        mbStadiaGarage.SetActive(false);
    }

    public override void StadiaUpgrade()
    {
        if (level == 0)
        {
            mbStadiaRoom1.SetActive(true);
            connector1.SetActive(true);
            level++;

        }
        else if (level == 1)
        {
            mbStadiaRoom2.SetActive(true);
            level++;

        }
        else if (level == 2)
        {
            mbStadiaRoom3.SetActive(true);
            level++;

        }
        else if (level == 3)
        {
            mbStadiaRoom4.SetActive(true);
            level++;

        }
        else if (level == 4)
        {
            mbStadiaRoom5.SetActive(true);
            level++;

        }
        else if (level == 5)
        {
            mbStadiaRoom6.SetActive(true);
            level++;

        }
        else if (level == 6)
        {
            mbStadiaRoom7.SetActive(true);
            level++;

        }
        else if (level == 7)
        {
            mbStadiaRoom8.SetActive(true);
            level++;

        }
        else if (level == 8)
        {
            mbStadiaGarden.SetActive(true);
            connector2.SetActive(true);
            level++;

        }
        else if (level == 9)
        {
            mbStadiaGarage.SetActive(true);
            connector3.SetActive(true);
            level++;
        }
    }

}
