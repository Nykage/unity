using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollisions : MonoBehaviour
{

    public Collider2D oppositeCollision;
    public bool isColliding;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isColliding)
        {
            oppositeCollision.GetComponent<MovingObject>().canMove = false;
        }
        else
        {
            oppositeCollision.GetComponent<MovingObject>().canMove = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collision") || collision.CompareTag("Object") || collision.CompareTag("breakable") || collision.CompareTag("HitSwitch") || collision.CompareTag("NPC"))
        {
            isColliding = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Collision") || collision.CompareTag("Object") || collision.CompareTag("breakable") || collision.CompareTag("HitSwitch") || collision.CompareTag("NPC"))
        {
            isColliding = false;
        }
    }

}
