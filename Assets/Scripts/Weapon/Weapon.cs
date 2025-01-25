using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : LinkActorReference
{
    [SerializeField] private WeaponSO weaponSO;
    public WeaponSO WeaponSO => weaponSO;

    private Animator weaponAnim;
    private AnimatorOverrideController aoc;
    protected override void Awake()
    {
        base.Awake();
        weaponAnim = GetComponent<Animator>();
        aoc = new AnimatorOverrideController(weaponAnim.runtimeAnimatorController);
        weaponAnim.runtimeAnimatorController = aoc;
    }


    public void ChangeWeapon(WeaponSO newWeaponSO) {
        weaponSO = newWeaponSO;
        ReloadAnimationWeapon();
    }

    public void ReloadAnimationWeapon() {
        // aoc["Base_Attack_01"] = weaponSO.baseAttack01;
        // aoc["Base_Attack_02"] = weaponSO.baseAttack02;
        // aoc["Base_Attack_03"] = weaponSO.baseAttack03;
    }

    public void Active() {
        // weaponAnim.SetTrigger()
    }
}
