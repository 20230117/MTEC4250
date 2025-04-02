using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_IncreaseMaxAP : MonoBehaviour
{
    public Main main;
    void Start()
    {
        
    }

    public void b_increaseAP()
    {
        if (main.currentAP == main.maxAP)
        {
            main.currentAP = 0;
            main.maxAP += 1;
            main.b_increaseAP.interactable = false;
        }
        else
        {

        }
    }

    void Update()
    {
        
    }
}
