using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ActorMove : LinkActorReference
{
    [SerializeField] private float moveSpeed;
    public float MoveSpeed { get => moveSpeed;
        set {
            moveSpeed = value;
        }
    }

    [ReadOnly(true)]
    [SerializeField] private Vector2 direction;
    public Vector2 Direction { get => direction;
        set {
            direction = value;
            // CheckFlipDirection(value);
            UpdateByDirection(value);
        }
    }

    [SerializeField] private bool canMove = true;
    public bool CanMove { get => canMove;
        set {
            canMove = value;
        }
    }

    void CheckFlipDirection(Vector2 direction) {
        if (direction.x > 0) {
            Reference.transform.localScale = new Vector2(Mathf.Abs(Reference.transform.localScale.x), Reference.transform.localScale.y);
        }
        else if (direction.x < 0)  {
            Reference.transform.localScale = new Vector2(-Mathf.Abs(Reference.transform.localScale.x), Reference.transform.localScale.y);
        }
    }

    protected virtual void UpdateByDirection(Vector2 direction) {
        UpdateVision(direction);
    }

    private void UpdateVision(Vector2 direction)
    {
        if (ActorReference.ActorVision == null) return;

        ActorReference.ActorVision.transform.position = (Vector2)Reference.transform.position + direction.normalized * 0.5f; // Điều chỉnh hệ số nếu cần thiết

        // Xoay tầm nhìn theo hướng của actor mà không thay đổi tỷ lệ
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        ActorReference.ActorVision.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }


    public virtual void MoveToTarget(Vector2 target) {
        Direction = (target - (Vector2)Reference.transform.position).normalized;

        // Tính toán vị trí mới
        Vector2 newPosition = (Vector2)Reference.transform.position + direction * moveSpeed * Time.deltaTime;
        Reference.Rigidbody.MovePosition(newPosition);
    }

    private IMoveState currentState;

    public void ChangeState(IMoveState newState) {
        currentState?.Exit(this);
        currentState = newState;
        currentState?.Enter(this);
    }

    protected override void Update()
    {
        if(!CanMove) return;
        currentState?.Excute(this);
    }
}
