using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface TurnObserver
{
    public void OnTurnChange(bool isPlayerTurn);
}

public class TurnCombatController : Singleton<TurnCombatController>
{
    private PlayerCharacterController player;
    private GenericCharacter enemy;

    private List<TurnObserver> turnObservers = new List<TurnObserver>();

    private bool isPlayerTurn = true;

    public void ChangeTurn()
    {
        isPlayerTurn = !isPlayerTurn;
        NotifyHPChange();
    }

    #region Turn Observers
    public void SubscribeTurnObserver(TurnObserver observer)
    {
        turnObservers.Add(observer);
    }

    public void RemoveTurnObserver(TurnObserver observer)
    {
        turnObservers.Remove(observer);
    }

    private void NotifyHPChange()
    {
        foreach (TurnObserver observer in turnObservers)
        {
            observer.OnTurnChange(isPlayerTurn);
        }
    }
    #endregion

    #region properties
    public GenericCharacter Enemy { get => enemy; set => enemy = value; }
    public PlayerCharacterController Player { get => player; set => player = value; }
    #endregion
}
