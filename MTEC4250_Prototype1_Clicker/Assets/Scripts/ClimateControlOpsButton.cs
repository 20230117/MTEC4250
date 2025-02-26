using UnityEngine;
using UnityEngine.UI;
using System;

public class ClimateControlOpsButton : MonoBehaviour
{
    public GameManager gameManager;
    public Timer timer;

    public Button climateControlButton;

    public int TimesUsed = 0;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        climateControlButton.onClick.AddListener(ClimateControlOps);
    }

    public void ClimateControlOps()
    {
        timer.TimeLeft += 60;
        gameManager.ResearchPoint -= gameManager.ClimateControlCost;
        gameManager.ClimateControlCost *= 2;
        TimesUsed += 1;
    }

    void Update()
    {
        if (gameManager.ResearchPoint < gameManager.ClimateControlCost)
        {
            climateControlButton.interactable = false;
        }
        else
        {
            climateControlButton.interactable = true;
        }
    }
}
