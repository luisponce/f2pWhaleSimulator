using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/StoreItem")]
public class SimpleStoreItem : ScriptableObject
{
    public Sprite icon;
    public int price = 100;
    public string name = "sampleItemName";

}
