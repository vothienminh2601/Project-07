using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : IMoveState
{
    Transform target;
    public ChaseState(Transform target) {
        this.target = target;
    }

    public void Enter(ActorMove actorMove)
    {

    }

    public void Excute(ActorMove actorMove)
    {
        if(target == null || !target.gameObject.activeSelf) {
            actorMove.ChangeState(new PatrolState(actorMove));
            return;
        }

        Vector2 targetPos = target.position;
        float distance = Vector2.Distance(targetPos, actorMove.ActorReference.transform.position);
        float attackRange = actorMove.ActorReference.ActorAttack.leftHand.WeaponSO.range;
        if(distance > attackRange) {
            actorMove.MoveToTarget(targetPos);
        }
        else {
            actorMove.ActorReference.ActorAttack.leftHand.Active();
        }
    }

    public void Exit(ActorMove actorMove)
    {

    }
}
