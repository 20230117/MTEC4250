using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameManager gameManager;

    public float TimeLeft = 120;

    public TMP_Text T_Timer;
    private string TimerText;

    void Start()
    {
        
    }

    void Update()
    {
        if (gameManager.GameLevel is 0)
        {
            TimerText = "until Earth becomes UNINHABITABLE";
        }
        else
        {
            TimerText = "until planet becomes UNINHABITABLE";
        }

        DisplayTime(TimeLeft);

        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;

            if (TimeLeft < 60)
            {
                T_Timer.color = Color.red;
            }
            else
            {
                T_Timer.color = Color.white;
            }
        }
        else if (TimeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void DisplayTime (float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        T_Timer.text = string.Format("{0:00} : {1:00}", minutes, seconds) + " " + TimerText;
    }
}
