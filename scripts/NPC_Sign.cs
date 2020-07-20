using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Sign : MonoBehaviour
{
    public GameObject dialogueBox;
    public Text dialogueText;
    public string dialogue;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && playerInRange)
        {
            if (dialogueBox.activeInHierarchy)
            {
                dialogueBox.SetActive(false);
                SoundManager.PlaySound("dialogue");
            }
            else
            {
                dialogueBox.SetActive(true);
                SoundManager.PlaySound("dialogue");
                dialogueText.text = dialogue;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            dialogueBox.SetActive(false);
        }
    }
}
