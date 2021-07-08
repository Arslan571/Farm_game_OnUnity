using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    public static UIBehavior instance = null;

   [SerializeField] Text totalUpgradeText;
   [SerializeField] Text totalUpgradeButtonText;

    List<Building> activeBuilds;
    List<string> inactiveBuilds;

    private int buildIndex = 0;
    private int maxBuildIndex = 2;
    //private bool upgradeIsActive = true;

    [SerializeField] Text debuggingText;
    

    private void Start()
    {
        InitInstance();

        Init();
    }

    private void Init()
    {
        activeBuilds = new List<Building>();
        inactiveBuilds = new List<string>();

        activeBuilds.Add(MainBaseManager.instance);
        activeBuilds.Add(SolarPanelManager.instance);
        activeBuilds.Add(GarageManager.instance);

       // totalUpgradeText.text = "Upgrade " + activeBuilds[buildIndex].buildName;
    }

    public void TotalUpgradeClick()
    {
        Debug.Log(activeBuilds[0].buildName);

            if (buildIndex <= maxBuildIndex)
            {
                totalUpgradeText.text = "Upgrade " + activeBuilds[buildIndex].buildName;

                UniversalUpgradeClick(activeBuilds[buildIndex]);

                buildIndex++;
            }
            else
            {
                buildIndex = 0;
            }
       
    }

    public void AddBuild(Building _build)
    {
        activeBuilds.Add(_build);
    }


    public void UniversalUpgradeClick(Building _build)
    {
        Economic.instance.Buying(_build.price);

        if(Economic.instance.buyingIsTrue == true)
        {
            _build.StadiaUpgrade();
            _build.price = Economic.instance.CoastUpgrade(_build.price, _build.coef);
        }
    }

    public void SolarButtonClick()
    {
        UniversalUpgradeClick(SolarPanelManager.instance);
    }

    public void BaseButtonClick()
    {
        UniversalUpgradeClick(MainBaseManager.instance);
    }

    private void InitInstance()
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
}
