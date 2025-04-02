using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerGamePiece : MonoBehaviour
{
    public static PlayerGamePiece instance;

    private void Awake()
    {
        instance = this;
    }

    public int healthPointsSpawned;
    public int healthPoints;

    public TMP_Text HP;

    void Start()
    {
        healthPointsSpawned = Random.Range(4, 8);
        healthPoints = healthPointsSpawned;
    }

    public void Endturn()
    {
        healthPoints -= 1;
    }

    void Update()
    {
        HP.text = healthPoints.ToString();

        if (healthPoints == 0)
        {
            Destroy(gameObject);
        }
    }
}
