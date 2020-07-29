using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSwitch : MonoBehaviour
{
    public bool switchActive;
    public bool reversed;
    public GameObject target;

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
                target.SetActive(true);
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
                target.SetActive(false);
            }
        }
    }
}
