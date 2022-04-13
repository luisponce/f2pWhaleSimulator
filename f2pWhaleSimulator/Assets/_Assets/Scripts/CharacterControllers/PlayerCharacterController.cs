using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : GenericCharacter
{
    #region animation variables
    private const string ANIM_ATTACK = "Attack";
    #endregion

    [SerializeField]
    private Animator PlayerAnimator;
    
    private void Start()
    {
        TurnCombatController.Instance.Player = this;
    }

    public override void Attack(GenericCharacter target)
    {
        base.Attack(target);

        PlayerAnimator.SetTrigger(ANIM_ATTACK);
    }

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
