using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorReference : Reference
{
    [Header("Actor Reference")]
    [Header("Health")]
    [SerializeField] private ActorStats actorStats;
    public ActorStats ActorStats { get => actorStats; }
    [SerializeField] private ActorDamageable actorDamageable;
    public ActorDamageable ActorDamageable { get => actorDamageable; }

    [Header("Action")]

    [SerializeField] private ActorMove actorMove;
    public ActorMove ActorMove { get => actorMove; }

    [SerializeField] private ActorAttack actorAttack;
    public ActorAttack ActorAttack { get => actorAttack; }

    [SerializeField] private ActorVision actorVision;
    public ActorVision ActorVision { get => actorVision; }

    protected override void RefComponents()
    {
        base.RefComponents();
        RefActorStats();
        RefActorDamageable();
        RefActorMove();
        RefActorAttack();
        RefActorVision();
    }

    void RefActorStats() {
        if(actorStats != null) return;
        actorStats = GetComponentInChildren<ActorStats>();
    }

    void RefActorDamageable() {
        if(actorDamageable != null) return;
        actorDamageable = GetComponentInChildren<ActorDamageable>();
    }

    void RefActorMove() {
        if(actorMove != null) return;
        actorMove = GetComponentInChildren<ActorMove>();
    }

    void RefActorAttack() {
        if(actorAttack != null) return;
        actorAttack = GetComponentInChildren<ActorAttack>();
    }

    void RefActorVision() {
        if(actorVision != null) return;
        actorVision = GetComponentInChildren<ActorVision>();
    }
}
