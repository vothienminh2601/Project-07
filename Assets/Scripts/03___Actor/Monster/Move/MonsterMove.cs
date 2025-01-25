using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : ActorMove
{
    protected override void Start()
    {
        ChangeState(new IdleState());
    }
}
