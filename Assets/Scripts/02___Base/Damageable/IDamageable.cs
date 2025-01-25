using UnityEngine;

public interface IDamageable 
{   
    bool TakeDamage(Transform damageSource, float amount);
}
