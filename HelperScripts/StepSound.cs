using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StepSound : MonoBehaviour
{
    [SerializeField]
    private float distanceBetweenSteps = 0.5f;

    [SerializeField]
    private float pitchRandomness = 0.1f;

    [SerializeField]
    private AudioClip stepSound;
    
    private Vector3 lastPosition;

    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void Start()
    {
        lastPosition = transform.position;
        InvokeRepeating("PlayStepSound", 0, 0.05f);
    }

    private void PlayStepSound()
    {
        if(Vector3.Distance(lastPosition, transform.position) >= distanceBetweenSteps)
        {
            source.pitch = 1 + UnityEngine.Random.Range(-pitchRandomness, pitchRandomness);
            lastPosition = transform.position;
            source.PlayOneShot(stepSound);
        }
    }
}
