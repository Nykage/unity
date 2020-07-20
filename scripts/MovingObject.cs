using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    public bool playerInRange;
    public Collider2D collisionSite;
    public Rigidbody2D parentBody;
    private Vector3 change;
    public bool y;
    public bool x;
    public bool negative;
    public bool positive;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        parentBody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            change = Vector3.zero;
            if (negative && x)
            {
                if (Input.GetAxisRaw("Horizontal") > 0)
                {
                    change = Vector3.zero;
                }
                else
                {
                    change.x = Input.GetAxisRaw("Horizontal");
                }
                MoveObject();
            }
            else if (positive && x)
            {
                if (Input.GetAxisRaw("Horizontal") < 0)
                {
                    change = Vector3.zero;
                }
                else
                {
                    change.x = Input.GetAxisRaw("Horizontal");
                }
                MoveObject();
            }
            else if (negative && y)
            {
                if (Input.GetAxisRaw("Vertical") > 0)
                {
                    change = Vector3.zero;
                }
                else
                {
                    change.y = Input.GetAxisRaw("Vertical");
                }
                MoveObject();
            }
            else if (positive && y)
            {
                if (Input.GetAxisRaw("Vertical") < 0)
                {
                    change = Vector3.zero;
                }
                else
                {
                    change.y = Input.GetAxisRaw("Vertical");
                }
                MoveObject();
            }
        }
    }

    void MoveObject()
    {
        if (Input.GetButton("Interact"))
        {
            parentBody.MovePosition(
                transform.position + change * speed * Time.deltaTime
            );
        }
    }

    public void OnTriggerEnter2D(Collider2D collisionSite)
    {
        if (collisionSite.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collisionSite)
    {
        if (collisionSite.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

}
