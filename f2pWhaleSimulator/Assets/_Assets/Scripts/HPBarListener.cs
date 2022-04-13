using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface HPObserver
{
    public void OnHPChange(int newHp);
}
public class HPBarListener : MonoBehaviour, HPObserver
{
    [SerializeField]
    private GenericCharacter HPTarget;
    [SerializeField]
    private ProgresBarUI HPBar;

    void Start()
    {
        HPTarget.SubscribeHPObserver(this);
        HPBar.UpdateProgresBar(HPTarget.CurHP);
    }

    public void OnHPChange(int newHp)
    {
        HPBar.UpdateProgresBar(newHp);
    }
}
