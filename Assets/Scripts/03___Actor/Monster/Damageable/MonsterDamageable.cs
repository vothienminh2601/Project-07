using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamageable : ActorDamageable
{
    protected override void Dead()
    {
        Reference.Despawn.DespawnObject();
    }
}
