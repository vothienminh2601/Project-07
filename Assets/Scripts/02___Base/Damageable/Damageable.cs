using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : LinkReference, IDamageable
{
    [SerializeField] private bool isAlive = false;
    public bool IsAlive { get => isAlive;
        set {
            isAlive = value;
        }
    }

    [SerializeField] private float maxHealth = 10;
    public float MaxHealth { get => maxHealth;
        set {
            maxHealth = value;
        }
    }

    [SerializeField] private float health;
    public float Health { get => health;
        set {
            health = value;
            if(value > maxHealth) {
                health = maxHealth;
            }

            if(value <= 0) {
                health = 0;
                Dead();
            }
        }
    }

    protected virtual void Dead() {}
    protected virtual void Reborn(float scale = 1) {
        Health = MaxHealth * scale;
        IsAlive = true;
    }

    public virtual bool TakeDamage(Transform damageSource, float damage) {
        if(!IsAlive) return false;
        Debug.Log(damage);
        Health -= damage;

        return true;
    }

}
