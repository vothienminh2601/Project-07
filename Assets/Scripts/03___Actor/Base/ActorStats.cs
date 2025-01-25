using UnityEngine;

public class ActorStats : Stats
{
    ActorReference actorReference;
    protected override void Awake()
    {
        base.Awake();
        actorReference = Reference as ActorReference;
    }

    [Header("Stats")]
    [Header("Base")]
    [SerializeField] private BaseStats stats;
}
