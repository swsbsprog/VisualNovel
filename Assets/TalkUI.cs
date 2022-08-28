using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkUI : MonoBehaviour
{
    public Text nameText;
    public Text talkText;
    public float talkSpeed = 0.1f;
    public void SetTalk(TurnInfo info)
    {
        talkText.DOText(info.talk, info.talk.Length * talkSpeed);
        nameText.text = info.Name;
    }

    internal void ClearText(bool clearText)
    {
        if (clearText == false)
            return;
        talkText.text = "";
        nameText.text = "";
    }
}
