using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericCharacter : MonoBehaviour
{
    [SerializeField]
    private int maxHP = 100;
    private int curHP = 100;

    [SerializeField]
    private int damage = 10;

    private List<HPObserver> hpObservers = new List<HPObserver>();

    public int CurHP { get => curHP; }

    public virtual void Attack(GenericCharacter target)
    {
        target.DealDamage(damage);
        TurnCombatController.Instance.ChangeTurn();
    }

    public void DealDamage(int damageReceived)
    {
        curHP -= damageReceived;
        NotifyHPChange();

        if(curHP <= 0)
        {
            Die();
        }
    }

    public abstract void Die();

    #region HP Observers
    public void SubscribeHPObserver(HPObserver observer)
    {
        hpObservers.Add(observer);
    }

    public void RemoveHPObserver(HPObserver observer)
    {
        hpObservers.Remove(observer);
    }

    private void NotifyHPChange()
    {
        foreach (HPObserver observer in hpObservers)
        {
            observer.OnHPChange(curHP);
        }
    }
    #endregion
}
