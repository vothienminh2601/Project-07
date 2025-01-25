using UnityEngine;

public class ItemSO : ScriptableObject
{
    public Sprite icon;
    public string nameItem;
    public string description;
    public BaseStats bonusStats;
    public ItemPassiveEffect itemPassiveEffect;
}
