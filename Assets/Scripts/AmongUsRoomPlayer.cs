using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class AmongUsRoomPlayer : NetworkRoomPlayer
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        base.Start(); // 부모의 Start 호출
        // 추가 로직
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
