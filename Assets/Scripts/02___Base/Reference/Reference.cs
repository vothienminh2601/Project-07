using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MScript
{
    [Header("Reference")]
    [SerializeField] private Rigidbody2D _rigidbody;
    public Rigidbody2D Rigidbody { get => _rigidbody;}
    [SerializeField] private Animator animator;
    public Animator Animator { get => animator;}
    [SerializeField] private Despawn despawn;
    public Despawn Despawn { get => despawn; }

    protected override void RefComponents()
    {
        RefRigidBody();
        RefAnimator();
        RefDespawn();
    }

    void RefRigidBody() {
        if(_rigidbody != null) return;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void RefAnimator() {
        if(animator != null) return;
        animator = GetComponentInChildren<Animator>();
    }

    void RefDespawn() {
        if(despawn != null) return;
        despawn = GetComponentInChildren<Despawn>();
    }
}
