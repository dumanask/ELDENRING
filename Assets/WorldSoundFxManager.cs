using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WorldSoundFxManager : MonoBehaviour
{
    public static WorldSoundFxManager instance;

    [Header("Action Sounds")]
    public AudioClip rollSFx;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
