using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDialogueOne : Dialogue
{
    protected override void PlayerDisplay(int id) 
    {
        Debug.Log("Player Dialogue One");
        playerUI1.GetComponentInChildren<TextMeshProUGUI>().text = FetchText(id+1);
    }
    
    public override void PlayerUIEnable()
    {
        Debug.Log("One Player UI Enable");
        playerUI1.SetActive(true);
    }

    public override void PlayerUIDisable()
    {
        Debug.Log("One Player UI Disable");
        playerUI1.SetActive(false);
    }
    
    public int GetResponse(int id)
    {
        int response;
        bool isParsable = Int32.TryParse(dialogueArr[id,1], out response);
        if (isParsable) return response;
        else return -1;
    }
}