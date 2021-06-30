using System.Diagnostics.Contracts;
using Sirenix.OdinInspector;
//using Sirenix.OdinInspector.Demos.RPGEditor;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "KillerProfile", menuName = "ScriptableObjects/KillerProfile")]
public class KillerProfile : ScriptableObject
{
    protected const string LEFT_VERTICAL_GROUP             = "Split/Left";
    protected const string BUILD1_BOX_GROUP                 = "Split/Left/Build 1/Split/";
    protected const string GENERAL_SETTINGS_VERTICAL_GROUP = "Split/Left/General/Split/";

    [HideLabel, PreviewField(55)]
    [VerticalGroup(LEFT_VERTICAL_GROUP)]
    [HorizontalGroup(LEFT_VERTICAL_GROUP + "/General/Split", 55, LabelWidth = 67)]
    public Sprite Icon;

    [BoxGroup(LEFT_VERTICAL_GROUP + "/General")]
    [VerticalGroup(GENERAL_SETTINGS_VERTICAL_GROUP + "Right")]
    public string Name;
    [BoxGroup(LEFT_VERTICAL_GROUP + "/General")]
    [VerticalGroup(GENERAL_SETTINGS_VERTICAL_GROUP + "Right")]
    public float scrollHeight;

    [HorizontalGroup("Split", 0.5f, MarginLeft = 5, LabelWidth = 130)]
    [BoxGroup("Split/Lore")]
    [HideLabel, TextArea(4, 9)]
    public string Lore;

    [TabGroup("Build 1")] 
    public string build1Name = "Generic";
    
    [TabGroup("Build 1")]
    public Perk perk1;
    
    [TabGroup("Build 1")]
    public Perk perk2;
    
    [TabGroup("Build 1")]
    public Perk perk3;
    
    [TabGroup("Build 1")]
    public Perk perk4;
    
    [TabGroup("Build 2")] 
    public string build2Name;
    
    [TabGroup("Build 2")]
    public Perk perk5;

    [TabGroup("Build 2")]
    public Perk perk6;

    [TabGroup("Build 2")]
    public Perk perk7;

    [TabGroup("Build 2")]
    public Perk perk8;
    
    [TabGroup("Build 3")] 
    public string build3Name;
    
    [TabGroup("Build 3")]
    public Perk perk9;

    [TabGroup("Build 3")]
    public Perk perk10;

    [TabGroup("Build 3")]
    public Perk perk11;

    [TabGroup("Build 3")]
    public Perk perk12;
    
    [TabGroup("Build 4")] 
    public string build4Name;
    
    [TabGroup("Build 4")]
    public Perk perk13;

    [TabGroup("Build 4")]
    public Perk perk14;

    [TabGroup("Build 4")]
    public Perk perk15;

    [TabGroup("Build 4")]
    public Perk perk16;
}
