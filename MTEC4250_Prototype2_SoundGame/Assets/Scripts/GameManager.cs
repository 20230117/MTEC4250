using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject Exit;
    public float distance;

    public Camera mainCam;
    //public CameraClearFlags clearFlags;

    void Start()
    {

    }

    void Update()
    {
        Vector3 position_Player = Player.transform.position;
        Vector3 position_Exit = Exit.transform.position;
        distance = Vector3.Distance(position_Player, position_Exit);

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            //mainCam.clearFlags = CameraClearFlags.Skybox;
            mainCam.enabled = !mainCam.enabled;
            //mainCam.cullingMask = everythingCullingMask;
        }
    }
}
