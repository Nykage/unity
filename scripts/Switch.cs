using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    private bool switchActive;
    public GameObject target;
    public string switchObject;
    private bool switchObjectActive;
    public bool reversed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reversed)
        {
            if (switchActive)
            {
                target.SetActive(false);
            }
            else
            {
                if (switchObjectActive)
                {
                    target.SetActive(false);
                }
                else
                {
                    target.SetActive(true);
                }
            }
        }
        else
        {
            if (switchActive)
            {
                target.SetActive(true);
            }
            else
            {
                if (switchObjectActive)
                {
                    target.SetActive(true);
                }
                else
                {
                    target.SetActive(false);
                }
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SoundManager.PlaySound("click");
            switchActive = true;
        }
        if (collision.CompareTag(switchObject))
        {
            SoundManager.PlaySound("click");
            switchObjectActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SoundManager.PlaySound("click");
            switchActive = false;
        }
        if (collision.CompareTag(switchObject))
        {
            SoundManager.PlaySound("click");
            switchObjectActive = false;
        }
    }

}
