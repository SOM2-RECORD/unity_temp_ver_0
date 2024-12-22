using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameRoomSettingsUI :  SettingsUI// 이미 작성된 클래스 상속 받기
{
    public void ExitGameRoom() // 게임 나가기 선택
    {
        var manager = AmongUsRoomManager.singleton; // 게임매니저
        
        if(manager.mode == Mirror.NetworkManagerMode.Host) //host
        {
            manager.StopHost(); //종료
        }
        else if(manager.mode == Mirror.NetworkManagerMode.ClientOnly) //client only
        {
            manager.StopClient();
        } 
    }
}
