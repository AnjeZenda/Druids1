using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerGaps : MonoBehaviour
{
    public GameObject gap;
    public Transform SpawnerGap;
    public Spawn condition;
    private bool cond1;
    private bool cond2;
    private GameObject currentGap;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(gap, SpawnerGap.position, Quaternion.identity);
    }

    private void SpawnGaps()
    {
        cond1 = condition.realRand;
        cond2 = condition.groundReal;
        if (cond1 == false && cond2 == true)
        {
            currentGap = Instantiate(gap, SpawnerGap.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        SpawnGaps();
    }
}
