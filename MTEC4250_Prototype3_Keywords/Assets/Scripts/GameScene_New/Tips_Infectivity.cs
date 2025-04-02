using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Tips_Infectivity : MonoBehaviour
{
    public GameObject tipPanel;
    public TMP_Text text;

    /*

    void OnMouseEnter()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            tipPanel.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            tipPanel.SetActive(false);
        }
    }

    */

    public void hover()
    {
        tipPanel.SetActive(true);
    }

    public void off()
    {
        tipPanel.SetActive(false);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
