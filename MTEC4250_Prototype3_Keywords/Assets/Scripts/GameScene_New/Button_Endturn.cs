using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Endturn : MonoBehaviour
{
    public Main main;

    void Start()
    {
        
    }

    public void Endturn()
    {
        if (main.currentAP is 0) //Can only end turn when current AP reaches 0.
        {
            

            if (main.turn >= 10)
            {
                if (main.frozen == true)
                {

                }
                else
                {
                    main.dead += main.killsPerTurn;
                    main.infected -= main.killsPerTurn;
                }
            }
            else
            {

            }

            
            main.turn += 1;
            main.currentAP = main.maxAP;
            main.infectPerClick += (main.maxAP + main.turn); //Infectivity scale

            main.b_Endturn.interactable = false;
            main.b_infect.interactable = true;

            if (main.turn >= 6)
            {
                main.b_increaseAP.interactable = true;
            }
            
        }
        else
        {

        }
    }

    void Update()
    {
        
    }
}
