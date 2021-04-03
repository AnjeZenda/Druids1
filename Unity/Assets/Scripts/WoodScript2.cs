using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodScript2 : MonoBehaviour
{
    bool MouseDown = false;
    public float speedWood;
    public GameObject wood;

    private void OnMouseDown()
    {
        MouseDown = true;
    }
    private void OnMouseUp()
    {
        MouseDown = false;
    }

    private void Update()
    {
        Vector3 cursor = Input.mousePosition;
        cursor = Camera.main.ScreenToWorldPoint(cursor);
        //Debug.Log(cursor);
        cursor.z = 0;
        if (MouseDown)
        {
            this.transform.position = cursor;
        }
        else
        {
            wood.transform.position += new Vector3(speedWood, 0, 0);
        }
        if (gameObject.transform.position.x < -17.82f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (MouseDown == false && other.tag == "Gap")
        {
            this.gameObject.transform.position = other.gameObject.transform.position;
        }
    }
}
