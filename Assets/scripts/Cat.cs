using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] private Inhale _inhale;
    [SerializeField] private Animator _animator;

    private void OnEnable()
    {
        _inhale.Animator = _animator;
    }
}
