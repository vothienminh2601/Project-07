using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkActorReference : LinkReference
{
    private ActorReference actorReference;
    public ActorReference ActorReference {get => actorReference;}
    protected override void Awake()
    {
        base.Awake();
        actorReference = (ActorReference)Reference;
    }
}
