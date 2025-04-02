using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tips_AP : MonoBehaviour
{
    public GameObject tipPanel;
    public TMP_Text text;

    public void hover()
    {
        tipPanel.SetActive(true);
    }

    public void off()
    {
        tipPanel.SetActive(false);
    }
}
