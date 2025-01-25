using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : LinkReference
{
    void OnTriggerEnter2D(Collider2D other) {
        ActorReference actorReference = other.GetComponentInParent<ActorReference>();
        if(actorReference == null) return;
        ActorDamageable actorDamageable = other.transform.parent.GetComponentInChildren<ActorDamageable>();
        if(actorDamageable == null) return;
        actorDamageable.TakeDamage(damageSource: Reference.transform, 1);
    }
}
