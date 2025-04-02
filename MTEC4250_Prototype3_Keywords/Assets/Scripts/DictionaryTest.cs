using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    public Dictionary <GameObject,int> dict = new Dictionary <GameObject,int> ();
    public GridManager grid;
    // Start is called before the first frame update
    void Start()
    {
        dict.Add(grid.RandomTile[0], 4);

        print(dict[grid.RandomTile[0]]);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
