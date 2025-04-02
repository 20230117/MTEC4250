using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public PlayerGamePiece playerGamePiece;
    public EnemyGamePiece enemyGamePiece;

    public int turn = 1;
    public int currentTurn = 1;
    public int maxAP = 1;
    public int currentAP;

    public TMP_Text UI_turn;
    public TMP_Text UI_AP;

    void Start()
    {
        currentAP = 0 + maxAP;
    }

    public void EndTurn()
    {
        
    }

    void Update()
    {
        UI_turn.text = "Turn" + " " + turn.ToString();
        UI_AP.text = "AP" + " " + currentAP.ToString();
    }
}
