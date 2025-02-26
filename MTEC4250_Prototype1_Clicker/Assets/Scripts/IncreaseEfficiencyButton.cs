using UnityEngine;
using UnityEngine.UI;

public class IncreaseEfficiencyButton : MonoBehaviour
{
    public GameManager gameManager;
    public Timer timer;

    public Button increaseEfficiencyButton;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        increaseEfficiencyButton.onClick.AddListener(efficiency);
    }

    public void efficiency()
    {
        gameManager.ResearchEfficiency += 1;
        gameManager.ResearchPoint -= gameManager.EfficiencyCost;
        gameManager.EfficiencyCost *= 1.5f;
        timer.TimeLeft -= gameManager.EfficiencyTimeReduction;
    }

    void Update()
    {
        if (gameManager.ResearchPoint < gameManager.EfficiencyCost)
        {
            increaseEfficiencyButton.interactable = false;
        }
        else if (gameManager.EfficiencyTimeReduction > timer.TimeLeft)
        {
            increaseEfficiencyButton.interactable = false;
        }
        else
        {
            increaseEfficiencyButton.interactable = true;
        }
    }
}
