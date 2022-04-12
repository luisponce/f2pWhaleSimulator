using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericCharacter : MonoBehaviour
{
    [SerializeField]
    private int maxHP = 100;
    protected int curHP = 100;

    [SerializeField]
    private int damage = 10;

    public void Attack(GenericCharacter target)
    {
        target.DealDamage(damage);
    }

    public void DealDamage(int damageReceived)
    {
        curHP -= damageReceived;

        if(curHP <= 0)
        {
            Die();
        }
    }

    public abstract void Die();
}
