using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    public Button GameStart;
    public Button MainMenu;
    public Button ExitGame;

    void Start()
    {
        GameStart.onClick.AddListener(game);
        MainMenu.onClick.AddListener(menu);
        ExitGame.onClick.AddListener(exit);
    }

    public void game()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void exit()
    {
        Application.Quit();
    }

    void Update()
    {
        
    }
}
