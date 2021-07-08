using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public string buildName;

    public GameObject[] _buildingParts;

    public Text priceText;
    public Button upgradeButton;
    public Slider progressBar;
 
    public float price;
    public float coef;
  
    public int level;
 
    public bool timeStart = false;


    protected virtual void Initialization(int buildCount, int activeBuildCount)
    {
        _buildingParts = new GameObject[buildCount];

        for(int i = 0; i < activeBuildCount; i++)
        {
            _buildingParts[i].SetActive(true);
        }
    }

    protected virtual void MainClick()
    {
        priceText.text = price.ToString();

        if (Input.GetMouseButtonDown(0) && timeStart == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject == this.gameObject)
                {
                    timeStart = true;

                    StartCoroutine(Delay());
                    priceText.text = price.ToString();
                }
            }
        }
    }

    public virtual void StadiaUpgrade()
    {

    }
    

    

    protected virtual IEnumerator Delay()
    {
        while(timeStart == true)
        {
           // progressBar.value -= Time.deltaTime;
            yield return new WaitForSeconds(2);
            timeStart = false;
        }
        Economic.instance.Earning(price);
    }

   // protected virtual void StadiaUpgrade(int level, int stadiaLevel) 
    

    public void BuildingPartsDefine(GameObject[] buildingParts, int buildCount)
    {
        for(int i = 0; i < buildCount; i++)
        {
           // _buildingParts.Add(buildingParts[i]);
        }
    }


}
