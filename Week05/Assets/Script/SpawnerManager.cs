using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnerManager : MonoBehaviour
{
    public List<Spawner> spawnerList = new List<Spawner>();

    public static SpawnerManager instance;

    void Start()
    {
        instance = this;
        Init();
    }

    private void Init()
    {
        Spawner[] spawnerArr = FindObjectsOfType<Spawner>();
        spawnerList = spawnerArr.ToList<Spawner>();
    }

    public void Spawn()
    {
        foreach(Spawner spawner in spawnerList)
        {
            spawner.Spawn();
        }
    }

}
