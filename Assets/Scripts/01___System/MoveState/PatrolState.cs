using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : IMoveState
{
    private List<Vector2> patrolPoints = new();
    private int currentPoint = 0;
    public int CurrentPoint { get => currentPoint;
        set {
            currentPoint = value;
            if(value >= patrolPoints.Count) {
                currentPoint = 0;
            }
        }
    }

    public PatrolState(List<Vector2> points) {
        patrolPoints = points;
    }

    public PatrolState(ActorMove actorMove) {
        patrolPoints = RandomPatrolPoints(actorMove);
    }

    List<Vector2> RandomPatrolPoints(ActorMove actorMove) {
        int randPoint = Random.Range(5, 10);
        List<Vector2> points = new();
        Vector2 actorPos = actorMove.transform.position;
        for(int i = 0; i < randPoint; i++) {
            float randX = Random.Range(actorPos.x -10, actorPos.x + 10);
            float randY = Random.Range(actorPos.y -10, actorPos.y + 10);
            points.Add(new Vector2(randX, randY));
        }

        return points;
    }

    public void Enter(ActorMove actorMove)
    {
        if (patrolPoints.Count > 0) {
            currentPoint = 0;
        }
    }

    public void Excute(ActorMove actorMove)
    {
        if(patrolPoints.Count == 0) return;

        Vector2 targetPos = patrolPoints[currentPoint];
        actorMove.MoveToTarget(targetPos);
        if (Vector3.Distance(actorMove.Reference.transform.position, targetPos) < 0.1f)
        {
            CurrentPoint += 1;
        }

        if(currentPoint == patrolPoints.Count) {
            actorMove.GetComponent<HumanMove>().ChangeState(new IdleState());
        }
    }

    public void Exit(ActorMove actorMove)
    {

    }
}
