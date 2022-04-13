using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : GenericCharacter
{
    private void Start()
    {
        TurnCombatController.Instance.Enemy = this;
    }

    public override void Die()
    {
        throw new System.NotImplementedException();
    }

    public void AttackPlayer()
    {
        //TODO: Decouple dependency
        Attack(TurnCombatController.Instance.Player);
    }
}
