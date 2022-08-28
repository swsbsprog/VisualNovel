using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public List<TurnInfo> turns;
    public TalkUI talkUI;
    public CharacterUI characterUI;
    void Start()
    {
        DoNext();
    }

    private void DoNext()
    {
        if(currentIndex >= turns.Count)
        {
            DoTurn(new TurnInfo()
            {
                Name ="안내",
                talk ="마지막입니다"
            });
            return;
        }
        DoTurn(turns[currentIndex]);
        currentIndex++;
    }

    private void DoTurn(TurnInfo dialogInfo)
    {
        talkUI.ClearText(dialogInfo.clearText);
        switch (dialogInfo.type)
        {
            case TurnInfo.Type.Talk:          
                DoTalk(dialogInfo); 
                break;
            case TurnInfo.Type.ActorEnter:    
            case TurnInfo.Type.ActorExit:     
                DoActor(dialogInfo); 
                break;
        }
    }

    public int currentIndex;
    void Update()
    {
        if(Input.anyKeyDown)
        {
            DoNext();
        }
    }

    private void DoActor(TurnInfo dialogInfo)
    {
        characterUI.SetCharacter(dialogInfo);
    }

    private void DoTalk(TurnInfo dialogInfo)
    {
        talkUI.SetTalk(dialogInfo);
    }
}
