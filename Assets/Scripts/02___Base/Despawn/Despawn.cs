using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : LinkReference
{
    protected override void Update()
    {
        if(CanDespawn()) DespawnObject();
    }

    protected virtual bool CanDespawn() {
        return false;
    }

    public virtual void DespawnObject() {
        Destroy(Reference.gameObject);
    }
}
