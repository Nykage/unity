using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip bgMusic, dialogueBox, swoosh, click, walking, fanfare, breakSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        bgMusic = Resources.Load<AudioClip>("little town");
        dialogueBox = Resources.Load<AudioClip>("dialogueBox");
        swoosh = Resources.Load<AudioClip>("swoosh");
        click = Resources.Load<AudioClip>("click");
        walking = Resources.Load<AudioClip>("walking");
        fanfare = Resources.Load<AudioClip>("Fanfare");
        breakSound = Resources.Load<AudioClip>("break");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "bgm":
                audioSrc.PlayOneShot(bgMusic);
                break;
            case "dialogue":
                audioSrc.PlayOneShot(dialogueBox, 0.6f);
                break;
            case "swoosh":
                audioSrc.PlayOneShot(swoosh, 0.6f);
                break;
            case "click":
                audioSrc.PlayOneShot(click);
                break;
            case "fanfare":
                audioSrc.PlayOneShot(fanfare);
                break;
            case "break":
                audioSrc.PlayOneShot(breakSound, 0.4f);
                break;
        }
    }
}
