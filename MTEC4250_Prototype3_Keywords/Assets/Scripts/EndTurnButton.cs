using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnButton : MonoBehaviour
{
    public TileActivity tileActivity;
    public PlayerGamePiece playerGamePiece;
    public EnemyGamePiece enemyGamePiece;

    public GridManager gridManager;
    public GameManager gameManager;

    public GameObject TileSelected;

    void Start()
    {
        tileActivity = TileActivity.instance;
        //playerGamePiece = PlayerGamePiece.instance;
        //enemyGamePiece = EnemyGamePiece.instance;
        playerGamePiece = GameObject.FindGameObjectWithTag("PlayerPiece").GetComponent<PlayerGamePiece>();
        enemyGamePiece = GameObject.FindGameObjectWithTag("EnemyPiece").GetComponent<EnemyGamePiece>();
    }

    public void EndTurn()
    {
        // ****** Get random tile position for spawning enemy pieces ******

        int index = Random.Range(0, gridManager.RandomTile.Count);
        Debug.Log(gridManager.RandomTile[index].name);
        TileSelected = gridManager.RandomTile[index];

        // ****** Get random tile position for spawning enemy pieces ******

        //gameManager.EndTurn();

        tileActivity.EnemySpawn();

        gameManager.turn += 1;
        gameManager.currentAP = 0 + gameManager.maxAP;
        playerGamePiece.Endturn();
        enemyGamePiece.Endturn();
    }

    void Update()
    {
        
    }
}
