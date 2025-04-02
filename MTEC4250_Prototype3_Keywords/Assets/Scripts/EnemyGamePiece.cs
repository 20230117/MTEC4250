using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyGamePiece : MonoBehaviour
{
    public static EnemyGamePiece instance;

    private void Awake()
    {
        instance = this;
    }

    public int healthPointsSpawned;
    public int healthPoints;

    public TMP_Text HP;

    void Start()
    {
        healthPointsSpawned = Random.Range(3, 6);
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
