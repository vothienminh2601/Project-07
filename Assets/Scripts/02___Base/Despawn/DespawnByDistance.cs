using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    public Transform target;
    [SerializeField] private float distanceDespawn = 20;

    protected override void OnEnable()
    {
        // If target is null, set target is this position
        if(target == null) target = Reference.transform;
    }

    protected override bool CanDespawn()
    {
        float distance = Vector2.Distance(target.position, Reference.transform.position);
        if(distance < distanceDespawn) return false;
        target = null;
        return true;
    }
}
