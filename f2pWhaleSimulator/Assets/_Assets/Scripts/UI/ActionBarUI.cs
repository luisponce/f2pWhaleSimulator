using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBarUI : MonoBehaviour, TurnObserver
{
    private CanvasGroup actionBarCanvas;

    private const float alphaValueWhenInactive = 0.75f;

    private void Start()
    {
        TurnCombatController.Instance.SubscribeTurnObserver(this);
        actionBarCanvas = GetComponent<CanvasGroup>();
    }

    public void OnTurnChange(bool isPlayerTurn)
    {
        actionBarCanvas.interactable = isPlayerTurn;
        actionBarCanvas.alpha = isPlayerTurn ? 1f : alphaValueWhenInactive;
    }

    
}
