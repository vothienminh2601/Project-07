using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveState
{
    void Enter(ActorMove actorMove);
    void Excute(ActorMove actorMove);
    void Exit(ActorMove actorMove);
}
