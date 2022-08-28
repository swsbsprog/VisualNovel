using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CharacterUI : MonoBehaviour
{
    public Image image;
    public float fadeInDuration = 1;
    internal void SetCharacter(TurnInfo dialogInfo)
    {
        if(dialogInfo.type == TurnInfo.Type.ActorEnter)
            image.sprite = dialogInfo.Image;

        image.gameObject.SetActive(dialogInfo.type == TurnInfo.Type.ActorEnter);
        var color = image.color;
        color.a = 0;
        image.color = color;
        image.DOFade(1, fadeInDuration);
    }
}
