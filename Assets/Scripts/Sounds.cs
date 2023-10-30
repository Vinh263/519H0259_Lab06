using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] AudioSource musicEffect;
    public AudioClip background;

    private void Start()
    {
        musicEffect.clip = background;
        musicEffect.Play();
    }
}
