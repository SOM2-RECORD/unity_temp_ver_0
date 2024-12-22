using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

// 네트워크 룸 매니저 확장
public class AmongUsRoomManager : NetworkRoomManager
{

    public override void OnRoomServerConnect(NetworkConnectionToClient  conn)
    {
        base.OnRoomServerConnect(conn);

        Vector3 spawnPos = FindFirstObjectByType<SpawnPositions>().GetSpawnPosition();

        var player = Instantiate(spawnPrefabs[0], spawnPos, Quaternion.identity);
        NetworkServer.Spawn(player, conn);
    }
    
}
