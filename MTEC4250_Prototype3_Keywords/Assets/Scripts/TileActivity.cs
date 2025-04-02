using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileActivity : MonoBehaviour
{
    public static TileActivity instance;

    private void Awake()
    {
        instance = this;
    }

    public InfectButton _infect;
    public EndTurnButton _endTurn;
    public GameManager AP;
    //public GridManager EnemySpawnPosition;

    [SerializeField] private GameObject Highlight;

    [SerializeField] private GameObject PlayerSpawnTarget;
    [SerializeField] private GameObject PlayerPiece;
    //[SerializeField] private GameObject EnemySpawnTarget;
    [SerializeField] private GameObject EnemyPiece;

    public bool empty = true;

    // ****** Test ******

    RaycastHit2D hit_up;
    RaycastHit2D hit_down;
    RaycastHit2D hit_left;
    RaycastHit2D hit_right;

    // ****** Test ******

    void Start()
    {
        _infect = InfectButton.instance;
        AP = GameManager.instance;
        _endTurn = GameObject.Find("EndTurnButton").GetComponent<EndTurnButton>();
    }

    // ****** Highlights tile when mouse hovers over tile. ******

    void OnMouseEnter()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Highlight.SetActive(true);
        }    
    }

    void OnMouseExit()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Highlight.SetActive(false);
        }
    }

    // ****** Highlights tile when mouse hovers over tile. ******

    // ****** Spawns player game pieces when clicked ******

    private void OnMouseUp()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (_infect.InfectOn == true && empty == true && AP.currentAP > 0) 
            {
                Vector3 SpawnPosition_p = PlayerSpawnTarget.transform.position;
                GameObject PlayerPieceSpawned = Instantiate(PlayerPiece, SpawnPosition_p, Quaternion.identity);

                empty = false;
                
                if (AP.currentAP == 0)
                {

                }
                else
                {
                    AP.currentAP -= 1;
                }
            }
            else
            {
                
            }
        }
    }

    // ****** Spawns player game pieces when clicked ******

    // ****** Spawns enemy game pieces after player turn ******

    public void EnemySpawn()
    {
        Vector3 SpawnPosition_e = _endTurn.TileSelected.transform.position;
        GameObject EnemyPieceSpawned = Instantiate(EnemyPiece, SpawnPosition_e, Quaternion.identity);

        /*
        if (empty == true)
        {
            GameObject EnemyPieceSpawned = Instantiate(EnemyPiece, SpawnPosition_e, Quaternion.identity);

            empty = false;
        }
        else
        {
            //_endTurn.EndTurn();
        }
        */
    }

    // ****** Spawns enemy game pieces after player turn ******

    void FixedUpdate() // Test
    {
        hit_up = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 0.75f);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up) * 0.75f, Color.red);
        hit_down = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 0.75f);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.down) * 0.75f, Color.yellow);
        hit_left = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), 0.75f);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.left) * 0.75f, Color.green);
        hit_right = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 0.75f);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.right) * 0.75f, Color.blue);
    }
}
