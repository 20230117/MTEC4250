using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main : MonoBehaviour
{
    // ****** Game stats ******

    public int infected = 0;
    public int healthy = 80000000;
    public int dead = 0;
    public int immunity = 0;
    public int infectPerClick = 1;
    public int killsPerTurn;
    private float killsPerTurnRate;
    public int killsPerTurnMultiplier = 15;
    public int freezeCost = 3;
    public int recallCost = 2;

    public int turn = 1;
    public int maxAP = 3;
    public int currentAP;
    public bool frozen = false;

    // ****** Game stats ******

    // ****** Buttons ******

    public Button b_infect;
    public Button b_Endturn;
    public Button b_increaseAP;
    public Button b_freeze;
    public Button b_recall;

    // ****** Buttons ******

    // ****** UI elements ******

    public TMP_Text t_infected;
    public TMP_Text t_healthy;
    public TMP_Text t_dead;
    public TMP_Text t_immunity;

    public TMP_Text t_turn;
    public TMP_Text t_AP;
    public TMP_Text t_infectPerClick;

    public TMP_Text t_tip_freeze;
    public TMP_Text t_tip_recall;

    // ****** UI elements ******

    void Start()
    {
        // ****** initialize game stats ******

        currentAP = maxAP;

        // ****** initialize game stats ******

        // ****** initialize button status ******

        b_infect.interactable = true;
        b_increaseAP.interactable = false;
        b_Endturn.interactable = false;
        b_freeze.interactable = false;
        b_recall.interactable = false;

        // ****** initialize button status ******
    }

    void Update()
    {
        // ****** display UI texts ******
        
        t_turn.text = "Turn:" + " " + turn.ToString();
        t_AP.text = "AP:" + " " + currentAP.ToString();
        t_infectPerClick.text = "Infectivity:" + " " + infectPerClick.ToString();

        t_infected.text = "Infected population:" + " " + infected.ToString();
        t_healthy.text = "healthy population:" + " " + healthy.ToString();
        t_dead.text = "Dead population:" + " " + dead.ToString();
        t_immunity.text = "Population with immunity:" + " " + immunity.ToString();

        t_tip_freeze.text = "Freeze will temporarily prevent deaths for three turns. After three turns, population will resume to die and death rate ramps up faster with each use of freeze. \n \n AP Cost:" + " " + freezeCost.ToString();
        t_tip_recall.text = "Recall will immediately unfreeze frozen populations. However, the death rate won't ramp up faster after using recall. \n \n AP Cost:" + " " + recallCost.ToString();

        // ****** display UI texts ******

        // ****** Game balance ******

        if (currentAP == 0)
        {
            b_Endturn.interactable = true; // Can only end turn when currentAP reaches 0
        }

        if (turn >= 6 && currentAP == maxAP)
        {
            b_increaseAP.interactable = true; // Can only increase max AP after turn 5
        }
        else
        {
            b_increaseAP.interactable = false;
        }

        if (turn >= 15 && currentAP >= 3 && frozen == false)
        {
            b_freeze.interactable = true; // Can only freeze after turn 15
        }
        else
        {
            b_freeze.interactable = false;
        }

        if (frozen == true)
        {
            b_recall.interactable = true; // Can only use recall after using freeze
        }
        else
        {
            b_recall.interactable = false;
        }

        killsPerTurnRate = 0.01f + (0.01f * turn); // kills per turn calculation
        killsPerTurn = Mathf.RoundToInt(infected * killsPerTurnRate) + Mathf.RoundToInt((5 + 10 * (turn - 10)) * killsPerTurnMultiplier); // kills per turn calculation

        // ****** Game balance ******

        // ****** Game over conditions ******

        if (turn >= 10)
        {
            if (infected <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        // ****** Game over conditions ******

        // ****** void ******

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
