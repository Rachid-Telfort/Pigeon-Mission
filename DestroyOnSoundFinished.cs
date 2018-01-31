﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DestroyOnSoundFinished : MonoBehaviour {

    private AudioSource audioSource;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update() {
        if (!audioSource.isPlaying)
            Destroy(gameObject);
    }

}