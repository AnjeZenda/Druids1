using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptForMouse : MonoBehaviour
{
    bool MouseDown = false;

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
        if(MouseDown)
        {
            this.transform.position = cursor;
        }
    }
}
