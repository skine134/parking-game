using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using parking_game.Assets.Scripts.Character.Interface;
using parking_game.Assets.Scripts.Processes;

public class player : BaseCharacter
{   
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(processList.Count<1)
        {
            return;
        }
        Processes.startEvent(this.gameObject,processList[0]);
        Debug.Log(processList[0]);
        processList.RemoveAt(0);
    }
}
