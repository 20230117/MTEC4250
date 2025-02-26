using UnityEngine;
using UnityEngine.UI;

public class ResearchButton : MonoBehaviour
{
    public GameManager gameManager;

    public Button researchButton;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        researchButton.onClick.AddListener(research);
    }

    public void research()
    {
        gameManager.ResearchPoint += gameManager.ResearchEfficiency;
    }
}
