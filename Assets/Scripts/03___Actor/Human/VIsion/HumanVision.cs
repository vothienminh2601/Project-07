using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanVision : ActorVision
{
    HumanReference humanReference;
    protected override void Awake()
    {
        base.Awake();
        humanReference = Reference.GetComponent<HumanReference>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        MonsterReference monster = other.GetComponentInParent<MonsterReference>();
        if(monster == null) return;
        humanReference.ActorMove.ChangeState(new ChaseState(monster.transform));
    }
}
