using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inhale : MonoBehaviour
{
    public Animator Animator { get => _animator; set => _animator = value; }


    public AudioSource audioSource;
    private Animator _animator;

    public void PlayInhale()
    {
        audioSource.Play();
    }

    public void PauseInhale()
    {
        audioSource.Pause();
    }

    public void StartIdleAnimation()
    {
        _animator.SetBool("isInhale", false);
    }

    public void StartInhaleAnimation()
    {
        _animator.SetBool("isInhale", true);
    }
}
