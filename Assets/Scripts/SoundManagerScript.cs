﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static SoundManagerScript instance;
    public AudioSource audioSrc;
    public AudioClip coinSound;

    private void Awake()
    {
      instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
