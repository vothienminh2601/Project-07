using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : LinkActorReference
{
    [SerializeField] private float knockedBackTime = 0.2f;
    [SerializeField] private float knockedBackDamage = 30f;

    public void GetKnockedBack(Transform damageSource, float damage) {

        Vector2 knockback = (ActorReference.Rigidbody.transform.position - damageSource.position).normalized
        * knockedBackDamage * damage * ActorReference.Rigidbody.mass;

        ActorReference.Rigidbody.AddForce(knockback, ForceMode2D.Force);
        if(!ActorReference.ActorDamageable.IsAlive) return;
        StartCoroutine(KnockRoutine(ActorReference.Rigidbody));
        ActorReference.ActorMove.CanMove = false;
    }

    private IEnumerator KnockRoutine(Rigidbody2D rb) {
        yield return new WaitForSeconds(knockedBackTime);
        rb.linearVelocity = Vector2.zero;
        ActorReference.ActorMove.CanMove = true;
    }
}
