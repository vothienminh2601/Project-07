using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawn
{
    [SerializeField] private float timeDespawn = 10;
    [SerializeField] private float timer = 0;

    protected override bool CanDespawn()
    {
        timer += Time.deltaTime;
        if(timer < timeDespawn) return false;
        timer = 0;
        return true;
    }
}
