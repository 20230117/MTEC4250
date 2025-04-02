using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Recall : MonoBehaviour
{
    public Main main;
    public int timesUsed;

    void Start()
    {
        
    }

    public void Recall()
    {
        if (main.currentAP >= main.recallCost)
        {
            timesUsed ++;

            main.frozen = false;
            main.recallCost += (2 * timesUsed);
        }
    }

    void Update()
    {
        
    }
}
