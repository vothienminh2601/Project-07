using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IMoveState
{
    private float idleTime = 2;
    private float timer = 0;
    public IdleState(float idleTime) {
        this.idleTime = idleTime;
    }

    public IdleState() {

    }

    public void Enter(ActorMove actorMove)
    {

    }

    public void Excute(ActorMove actorMove)
    {
        timer += Time.deltaTime;
        if(timer < idleTime) return;
        timer = 0;
        actorMove.ChangeState(new PatrolState(actorMove));
    }

    public void Exit(ActorMove actorMove)
    {

    }
}
