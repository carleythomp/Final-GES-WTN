using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRanSound : MonoBehaviour
{
    private AudioSource source;
    // [SerializeField] AudioClip[] varSounds;
    //public AudioClip[] clips;
    [SerializeField] AudioClip toaster;
    [SerializeField] AudioClip microwave;
    [SerializeField] AudioClip kettle;
    public float flip;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
      RandomSound();
    }
    public void RandomSound()
    {
        flip = Random.Range(0, 3);

        if(Input.GetKeyDown("x"))
        {
            if(flip == 0)
            {
                source.Stop();
                source.PlayOneShot(toaster);
               
            }
            if(flip == 1)
            {
                source.Stop();
                source.PlayOneShot(microwave);
            }
            if(flip == 2)
            {
                source.Stop();
                source.PlayOneShot(kettle);
            }
            //source.Stop();
            //source.PlayOneShot(clips[Random.Range(0, clips.Length)]);
           
        }
        
        
      
     
    }
}
