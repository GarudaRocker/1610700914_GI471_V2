using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTest : MonoBehaviour
{
    public SpawnerManager spawnerManager;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnerManager.instance.Spawn();
        }
        
    }
}
