using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Rigidbody2D ground = GetComponent<Rigidbody2D>();
        ground.velocity = new Vector2(speed, 0);
    }
    void Update()
    {
        if (gameObject.transform.position.x < -17.82f)
        {
            Destroy(gameObject);
        }
    }
}
