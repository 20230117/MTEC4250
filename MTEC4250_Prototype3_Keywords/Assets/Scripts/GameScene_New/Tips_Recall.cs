using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips_Recall : MonoBehaviour
{
    public Main main;
    public GameObject tipPanel;
    
    void Update()
    {
        
    }

    public void hover()
    {
        tipPanel.SetActive(true);
    }

    public void off()
    {
        tipPanel.SetActive(false);
    }
}
