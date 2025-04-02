using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Freeze : MonoBehaviour
{
    public Main main;
    public int timesUsed = 0;
    public int turn_past;
    public int turn_current;
    
    void Start()
    {
        
    }

    public void freeze()
    {
        if (main.currentAP >= main.freezeCost)
        {
            timesUsed++;
            main.currentAP -= main.freezeCost;

            turn_past = main.turn;
            main.frozen = true;
            main.freezeCost += (3 * timesUsed);
            main.killsPerTurnMultiplier += 5;
            main.b_freeze.interactable = false;
        }
        else
        {

        }
    }

    void Update()
    {
        turn_current = main.turn;

        if (turn_current - turn_past == 3)
        {
            main.frozen = false;
        }
    }
}
