using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnIndicatorUI : MonoBehaviour, TurnObserver
{
    private void Start()
    {
        TurnCombatController.Instance.SubscribeTurnObserver(this);
    }

    public void OnTurnChange(bool isPlayerTurn)
    {
        throw new System.NotImplementedException();
    }
}
