using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : GenericCharacter
{
    public override void Die()
    {
        throw new System.NotImplementedException();
    }

    public void AttackEnemy()
    {
        //TODO: Decouple dependency
        Attack(TurnCombatController.Instance.Enemy);
    }
}
