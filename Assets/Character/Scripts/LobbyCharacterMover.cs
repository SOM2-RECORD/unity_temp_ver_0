using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyCharacterMover : CharacterMover
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void completeSpawn()
    {
        if(isLocalPlayer)
        {
            isMoveable = true;
        }
    }
}
