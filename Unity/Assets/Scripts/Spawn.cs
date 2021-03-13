using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Spawn : MonoBehaviour
{
    public GameObject ground;
    public Transform SpawnGround;
    public float firstNum;
    public float secondNum;
    private GameObject currentGround;
    private float posX;
    private void Start()
    {
        GroundSpawn();
    }

    void Update()
    {
        if(currentGround != null && currentGround.transform.position.x <= 0)
        {
            posX = currentGround.transform.position.x;
            GroundSpawn();
        }
    }

    public void GroundSpawn()
    {
        var random = new Random();
        var randomNum = random.Next(0, 100) < 60 ? firstNum : secondNum;
        Vector3 pos = new Vector3(randomNum+posX, 0, 0);
        currentGround = Instantiate(ground, SpawnGround.position + pos, Quaternion.identity);
        
    }
}
