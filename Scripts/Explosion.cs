using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioClip destroySound; // Som de coleta
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
       audioSource = gameObject.AddComponent<AudioSource>();
       audioSource.PlayOneShot(destroySound); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
