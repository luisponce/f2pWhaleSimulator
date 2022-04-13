using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCombatController : Singleton<TurnCombatController>
{
    private PlayerCharacterController player;
    private GenericCharacter enemy;
    
    private bool isPlayerTurn = true;

    

    public void ChangeTurn()
    {
        isPlayerTurn = !isPlayerTurn;
    }

    #region properties
    public GenericCharacter Enemy { get => enemy; set => enemy = value; }
    public PlayerCharacterController Player { get => player; set => player = value; }
    #endregion
}
