using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Inspectable]
[System.Serializable]
public class DialogInfo
{
    public enum Type
    {
        Talk,
        ActorEnter
    }

    [Inspectable]
    public Type type;

    [Header("Talk")]
    [Inspectable]
    public string Name;
    [Inspectable]
    public string talk;

    [Header("ActorEnter")]
    [Inspectable]
    public Sprite Image;
}