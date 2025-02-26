using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public int GameLevel = 0;

    public float ResearchPoint = 0;
    public float LabNumber = 0;
    public float ResearchEfficiency = 1;
    public double Power1 = 2, Power2 = 0;
    private double PowerCalc;

    public float LabCostInitial = 100;
    public float LabCost = 100;
    public float EfficiencyCost = 100;
    public float ClimateControlCostInitial = 50;
    public float ClimateControlCost = 50;
    public double CCRamp;
    public int SearchCostInitial = 250;
    public int SearchCost;
    private int SearchCostInitialAfterLvl4;
    private int SearchCostInitialAfterLvl9;
    public int MigrateCostInitial = 500;
    public int MigrateCost;
    private int MigrateCostInitialAfterLvl4;
    private int MigrateCostInitialAfterLvl9;

    public int RP_int;
    public int EffCost_int;
    public int CCCost_int;

    public float LabTimeReduction;
    public float EfficiencyTimeReduction;

    private float LabRPreset = 0.0f;
    public float LabRPinterval = 5;

    public TMP_Text T_GameLevel;
    public TMP_Text T_ResearchPoint;
    public TMP_Text T_LabNumber;
    public TMP_Text T_ResearchEfficiency;

    public TMP_Text T_LabCost;
    public TMP_Text T_EfficiencyCost;
    public TMP_Text T_ClimateControlCost;
    public TMP_Text T_SearchCost;
    public TMP_Text T_MigrateCost;

    void Start()
    {

    }

    void Update()
    {
        //******UI text******

        if (GameLevel == 0)
        {
            T_GameLevel.text = "The Earth";
        }
        else
        {
            T_GameLevel.text = "Exoplanet" + " " + GameLevel.ToString();
        }

        RP_int = Mathf.RoundToInt(ResearchPoint);
        EffCost_int = Mathf.RoundToInt(EfficiencyCost);
        CCCost_int = Mathf.RoundToInt(ClimateControlCost);

        T_ResearchPoint.text = "Research point:" + " " + RP_int.ToString();
        T_LabNumber.text = "Research labs built:" + " " + LabNumber.ToString();
        T_ResearchEfficiency.text = "Efficiency level:" + " " + ResearchEfficiency.ToString();

        T_LabCost.text = "Research points:" + " " + LabCost.ToString() + " \nTime cost:" + " " + LabTimeReduction.ToString();
        T_EfficiencyCost.text = "Research points:" + " " + EffCost_int.ToString() + " \nTime cost:" + " " + EfficiencyTimeReduction.ToString();
        T_ClimateControlCost.text = "Research points:" + " " + CCCost_int.ToString() + " \nTimer + 60 seconds";
        T_SearchCost.text = "Research points:" + " " + SearchCost.ToString();
        T_MigrateCost.text = "Research points:" + " " + MigrateCost.ToString() + " \nLevel up, + 60 seconds";

        //******UI text******

        //******Time penalty******

        LabTimeReduction = LabNumber * 5;
        EfficiencyTimeReduction = ResearchEfficiency * 10;

        //******Time penalty******

        //******Lab RP generation******

        LabRPreset += Time.deltaTime;

        if (LabRPreset >= LabRPinterval)
        {
            ResearchPoint += LabNumber * 5 * ResearchEfficiency;

            LabRPreset = 0.0f;
        }
        else
        {

        }

        //******Lab RP generation******

        //******Game balance******

        //ClimateControlCost = 
        PowerCalc = Math.Pow(Power1, Power2 - 9);
        int Ramp = Convert.ToInt32(PowerCalc);

        if (GameLevel == 4)
        {
            SearchCostInitialAfterLvl4 = SearchCost;
            MigrateCostInitialAfterLvl4 = MigrateCost;
        }
        else if (GameLevel == 9)
        {
            SearchCostInitialAfterLvl9 = SearchCost;
            MigrateCostInitialAfterLvl9 = MigrateCost;
        }

        if (GameLevel <= 4)
        {
            SearchCost = SearchCostInitial + 250 * GameLevel;
            MigrateCost = MigrateCostInitial + 500 * GameLevel;
        }
        else if (GameLevel > 4 && GameLevel <= 9)
        {
            SearchCost = SearchCostInitialAfterLvl4 + 500 * (GameLevel - 4);
            MigrateCost = MigrateCostInitialAfterLvl4 + 1000 * (GameLevel - 4);
        }
        else if (GameLevel > 9)
        {
            SearchCost = SearchCostInitialAfterLvl9 * Ramp;
            MigrateCost = MigrateCostInitialAfterLvl9 * Ramp;
        }

        //******Game balance******
    }
}
