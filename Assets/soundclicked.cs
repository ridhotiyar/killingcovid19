using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundclicked : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip virusHit, handHit;
    static AudioSource audioSrc;
    void Start()
    {
        virusHit = Resources.Load<AudioClip> ("virus");
        handHit = Resources.Load<AudioClip> ("hand");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip){
        case "virus":
            audioSrc.PlayOneShot (virusHit);
            break;
        case "hand":
            audioSrc.PlayOneShot (handHit);
            break;
        }
    }
}
