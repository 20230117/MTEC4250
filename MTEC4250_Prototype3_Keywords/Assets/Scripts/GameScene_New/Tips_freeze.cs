using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tips_freeze : MonoBehaviour
{
    public Main main;
    public GameObject tipPanel;
    //public TMP_Text text;

    void Update()
    {
        //text.text = "AP cost:" + " " + main.freezeCost.ToString();
    }

    public void hover()
    {
        tipPanel.SetActive(true);
        //text.text = "AP cost:" + " " + main.freezeCost.ToString();
    }

    public void off()
    {
        tipPanel.SetActive(false);
    }
}
