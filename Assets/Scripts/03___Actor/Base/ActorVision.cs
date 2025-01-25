using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof (Collider2D))]
public class ActorVision : LinkReference
{
    protected List<Collider2D> targets = new();
}
