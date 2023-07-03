using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundFxManager : MonoBehaviour
{
    private AudioSource audioSource;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayRollSoundFx()
    {
        audioSource.PlayOneShot(WorldSoundFxManager.instance.rollSFx);
    }
}
