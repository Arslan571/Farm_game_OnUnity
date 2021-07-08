using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMuter : MonoBehaviour
{
    public bool is_music = false;

    private AudioSource audioSource;
    private float base_volume = 1f;

    private void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        base_volume = audioSource.volume;
    }

    private void Update()
    {
        if (is_music)
        {
            audioSource.volume = (AudioManager.music) ? base_volume : 0f;
        }
        else
        {
            audioSource.volume = (AudioManager.sounds) ? base_volume : 0f;
        }
    }
}
