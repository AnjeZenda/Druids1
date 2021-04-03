using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GapMoving : MonoBehaviour
{
    public float speed;
    public GameObject gap;

    void Update()
    {
        gap.transform.position += new Vector3(speed, 0, 0);
        if (gameObject.transform.position.x < -17.82f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            return;
        }
    }
}
