using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Inspectable]
[System.Serializable]
public class TurnInfo
{
    public enum Type
    {
        Talk,
        ActorEnter,
        ActorExit,
    }

    [Inspectable]
    public Type type;

    [Inspectable]
    public string Name;
    [Inspectable]
    public string talk;

    [Inspectable]
    public Sprite Image;

    public bool clearText = true;
}