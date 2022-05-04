using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnUse : MonoBehaviour
{
    [SerializeField]
    private AudioClip clip;

    [SerializeField]
    [Range(0f, 1f)]
    private float volume = 0.4f;
    public void PlayClip()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position, volume);
    }
}
