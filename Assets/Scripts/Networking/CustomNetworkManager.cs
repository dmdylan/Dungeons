using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomNetworkManager : NetworkManager
{
    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);


        //TODO: Throws null reference error for client that isn't server
        //conn.identity.gameObject.name = $"Player {conn.connectionId}";
    }
}
