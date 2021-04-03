using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed;
    public GameObject ground;

    void Update()
    {
        ground.transform.position += new Vector3(speed, 0, 0);
        if (gameObject.transform.position.x < -17.82f)
        {
            Destroy(gameObject);
        }
    }
}
