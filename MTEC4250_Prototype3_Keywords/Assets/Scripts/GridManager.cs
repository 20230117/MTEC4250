using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager instance;

    private void Awake()
    {
        instance = this;

        GenerateGrid();
    }

    public GameObject tilePrefab;
    public int grid_x; //Grid size
    public int grid_y; //Grid size

    public List<GameObject> RandomTile;

    void Start()
    {
        
    }

    void GenerateGrid()
    {
        for (int x = 0; x < grid_x; x ++)
        {
            for (int y = 0; y < grid_y; y ++)
            {
                GameObject SpawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                SpawnedTile.name = $"Tile [{x},{y}]";

                RandomTile.Add(SpawnedTile);
            }
        }
    }

    void Update()
    {

    }
}
