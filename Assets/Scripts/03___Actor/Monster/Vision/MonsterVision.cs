using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterVision : ActorVision
{
    MonsterReference monsterReference;
    protected override void Awake()
    {
        base.Awake();
        monsterReference = Reference.GetComponent<MonsterReference>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        HumanReference human = other.GetComponentInParent<HumanReference>();
        if(human == null) return;
        monsterReference.ActorMove.ChangeState(new ChaseState(human.transform));

    }
}
