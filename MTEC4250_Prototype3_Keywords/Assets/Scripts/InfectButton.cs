using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfectButton : MonoBehaviour
{
    public static InfectButton instance;

    private void Awake()
    {
        instance = this;
    }

    public bool InfectOn = false;

    public void Infect()
    {
        InfectOn = !InfectOn;
    }

    public void UIgraphics()
    {

    }

    void Update()
    {
        
    }
}
