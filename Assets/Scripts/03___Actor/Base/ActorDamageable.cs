using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorDamageable : Damageable
{
    private Knockback knockback;

    protected override void Awake()
    {
        base.Awake();
        knockback = GetComponentInChildren<Knockback>();
    }
    protected override void Start()
    {
        Reborn();
    }

    public override bool TakeDamage(Transform damageSource, float damage)
    {
        if(!base.TakeDamage(damageSource, damage)) return false;
        if(knockback == null) return true;
        knockback.GetKnockedBack(damageSource, damage);
        return true;
    }
}
