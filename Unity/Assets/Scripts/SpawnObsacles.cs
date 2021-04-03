using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObsacles : MonoBehaviour
{
    public GameObject wood;
    public Transform ObsacleSpawner;
    public Spawn condition;
    private bool cond1;
    private bool cond2;
    private void Start()
    {
        Instantiate(wood, ObsacleSpawner.position, Quaternion.identity);
    }
    private void SpawnWood()
    {
        cond1 = condition.realRand;
        cond2 = condition.groundReal;
        if (cond1 == false && cond2 == true)
        {
            Instantiate(wood, ObsacleSpawner.position, Quaternion.identity);
        }
    }
    private void Update()
    {
        SpawnWood();
    }
}
