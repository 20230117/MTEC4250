using UnityEngine;
using UnityEngine.UI;

public class BuildLabButton : MonoBehaviour
{
    public GameManager gameManager;
    public Timer timer;

    public Button buildResearchLabButton;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        buildResearchLabButton.onClick.AddListener(buildResearchLab);
    }

    public void buildResearchLab()
    {
        gameManager.LabNumber += 1;
        gameManager.ResearchPoint -= gameManager.LabCost;
        gameManager.LabCost += gameManager.LabCostInitial;
        timer.TimeLeft -= gameManager.LabTimeReduction;
    }

    void Update()
    {
        if (gameManager.ResearchPoint < gameManager.LabCost)
        {
            buildResearchLabButton.interactable = false;
        }
        else if (gameManager.LabTimeReduction > timer.TimeLeft)
        {
            buildResearchLabButton.interactable = false;
        }
        else
        {
            buildResearchLabButton.interactable = true;
        }
    }
}