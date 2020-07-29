using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("breakable"))
        {
            SoundManager.PlaySound("break");
            collision.GetComponent<Break>().Smash();
        }
        if (collision.CompareTag("HitSwitch"))
        {
            SoundManager.PlaySound("click");
            collision.GetComponent<HitSwitch>().switchActive = true;
        }
        if (collision.CompareTag("FinalSwitch"))
        {
            SoundManager.PlaySound("fanfare");
            collision.GetComponent<HitSwitch>().switchActive = true;
        }
    }
}
