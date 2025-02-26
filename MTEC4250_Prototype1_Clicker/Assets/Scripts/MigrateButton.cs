using UnityEngine;
using UnityEngine.UI;
using System;

public class MigrateButton : MonoBehaviour
{
    public GameManager gameManager;
    public Timer timer;
    public ClimateControlOpsButton CCOpsButton;
    public SearchPlanetButton searchPlanetButton;

    public Button migrateToPlanetButton;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        migrateToPlanetButton.onClick.AddListener(migrate);
    }

    public void migrate()
    {
        gameManager.ResearchPoint -= gameManager.MigrateCost;
        gameManager.GameLevel += 1;
        gameManager.Power2 += 1;
        timer.TimeLeft += 60;

        gameManager.LabNumber = 0;
        gameManager.LabCostInitial += 50;
        gameManager.LabCost = gameManager.LabCostInitial;

        for (int i = 0; i < CCOpsButton.TimesUsed; i++)
        {
            if (CCOpsButton.TimesUsed == 0)
            {

            }
            else
            {
                gameManager.CCRamp = Math.Sqrt(gameManager.ClimateControlCost);
            }
        }
        int CCRampCalc = Convert.ToInt32(gameManager.CCRamp);
        if (CCOpsButton.TimesUsed < 1)
        {

        }
        else
        {
            gameManager.ClimateControlCost = gameManager.ClimateControlCostInitial + CCRampCalc;
        }
        gameManager.ClimateControlCostInitial += CCRampCalc;
        CCOpsButton.TimesUsed = 0;

        searchPlanetButton.Searched = false;
    }

    void Update()
    {
        if (gameManager.MigrateCost > gameManager.ResearchPoint)
        {
            migrateToPlanetButton.interactable = false;
        }
        else if (searchPlanetButton.Searched == false)
        {
            migrateToPlanetButton.interactable = false;
        }
        else
        {
            migrateToPlanetButton.interactable = true;
        }
    }
}
