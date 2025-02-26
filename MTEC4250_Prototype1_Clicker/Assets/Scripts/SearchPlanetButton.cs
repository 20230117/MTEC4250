using UnityEngine;
using UnityEngine.UI;

public class SearchPlanetButton : MonoBehaviour
{
    public GameManager gameManager;

    public Button searchPlanetButton;

    public bool Searched = false;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        searchPlanetButton.onClick.AddListener(searchForPlanet);
    }

    public void searchForPlanet()
    {
        gameManager.ResearchPoint -= gameManager.SearchCost;

        Searched = true;
    }

    void Update()
    {
        if (gameManager.SearchCost > gameManager.ResearchPoint)
        {
            searchPlanetButton.interactable = false;
        }
        else if (Searched == true)
        {
            searchPlanetButton.interactable = false;
        }
        else
        {
            searchPlanetButton.interactable = true;
        }
    }
}
