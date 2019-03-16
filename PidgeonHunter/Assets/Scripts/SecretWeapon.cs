using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWeapon : MonoBehaviour
{
    public float attackDamage;
    public float attackRange;
    public float attackCooldown;

    public void ResetAttack()
    {
        transform.GetComponentInParent<PlayerMeleeAttack>().StopAttack();
    }
}
