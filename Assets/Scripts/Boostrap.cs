using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostrap : MonoBehaviour
{
    public GameObject solar_panel_manager;
    public GameObject main_base_manager;
    public GameObject economic_manager;
    public GameObject UI_manager;
    public GameObject audio_manager;

    private void Awake()
    {
        if(SolarPanelManager.instance == null)
        {
            Instantiate(solar_panel_manager);
        }

        if(MainBaseManager.instance == null)
        {
            Instantiate(main_base_manager);
        }

        if(Economic.instance == null)
        {
            Instantiate(economic_manager);
        }

        if(UIBehavior.instance == null)
        {
            Instantiate(UI_manager);
        }

        if(AudioManager.instance == null)
        {
            Instantiate(audio_manager);
        }
    }
}
