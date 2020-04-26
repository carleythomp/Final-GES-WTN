using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRanSound : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] AudioClip[] varSounds;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
}
