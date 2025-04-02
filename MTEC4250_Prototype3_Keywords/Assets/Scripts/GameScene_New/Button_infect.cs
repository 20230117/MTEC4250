using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_infect : MonoBehaviour
{
    public Main main;

    void Start()
    {
        
    }

    public void b_Infect()
    {
        if (main.currentAP > 0)
        {
            main.infected += main.infectPerClick;
            main.healthy -= main.infectPerClick;
            main.currentAP -= 1;
        }
        else
        {
            
        }
    }

    void Update()
    {
        if (main.currentAP == 0)
        {
            main.b_infect.interactable = false;
        }
    }
}
