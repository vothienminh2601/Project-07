using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove : ActorMove
{
    protected override void Start()
    {
        ChangeState(new IdleState());
    }
}
