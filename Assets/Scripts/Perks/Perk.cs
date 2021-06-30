using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "KillerProfile", menuName = "ScriptableObjects/Perk")]
public class Perk : ScriptableObject
{
    [HorizontalGroup("Perk", 75)]
    [BoxGroup("Perk/Sprite")]
    [HideLabel, PreviewField(55)]
    public Sprite icon;
    
    [BoxGroup("Perk/Info")]
    [TextArea(3, 10), HideLabel]
    public string info;
    
    [BoxGroup("Perk/Name"),HideLabel]
    public string Name;
}