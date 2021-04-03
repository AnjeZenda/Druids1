using UnityEngine;

public class WoodScript : MonoBehaviour
{
    private readonly float speed = 15.1f;
    private Vector3 startPos;
    private Vector3 endPos;
    public float speedWood;
    public GameObject wood;

    private void Start()
    {
        //Rigidbody2D WoodRb = GetComponent<Rigidbody2D>();
        //WoodRb.velocity = new Vector2(speedWood, 0);
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;
                case TouchPhase.Moved:
                    endPos = touch.position;
                    DoMove(startPos, endPos);
                    break;
            }
        }
        else
        {
            wood.transform.position += new Vector3(speedWood, 0, 0);
        }


        //if (Input.GetMouseButtonDown(0))
        //{
        //    startPos = Input.mousePosition;
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    endPos = Input.mousePosition;
        //    DoMove(startPos, endPos);
        //}
        if (gameObject.transform.position.x < -17.82f)
        {
            Destroy(gameObject);
        }
    }
    private void DoMove(Vector3 start, Vector3 destination)
    {
        var shift = (destination - start) * 0.01f;
        var objectPos = transform.position + new Vector3(shift.x, shift.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, objectPos, Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gap"))
        {
            this.transform.position = other.transform.position;
        }
    }
}
