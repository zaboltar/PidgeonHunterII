using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour
{ 
    public GameObject playerUnitPrefabObj;
    //syncvar es equivalente a usar rpc, el contrauso de command
    [SyncVar(hook="OnPlayerNameChanged")]
    public string PlayerName = "PidgeonHunter001";

    // Start is called before the first frame update
    void Start()
    { // sólo acá isLocalPlayer retorna True!!!!!
        if (isLocalPlayer == false) 
        {
            return;
        } 

        CmdSpawnMyUnit();
    }

    // Update is called once per frame
    void Update()
    {
          if (isLocalPlayer == false) {
            return;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
           CmdSpawnMyUnit();
        }

         if (Input.GetKeyDown(KeyCode.Q))
        {
           string n = "PidgeonHunter" + Random.Range(1,666);
           
           CmdChangePlayerName(n);
        }
    }

    void OnPlayerNameChanged(string newName)
    {
        PlayerName = newName;
        gameObject.name = "PlayerConnectionObject ["+newName+"]";
    }

    //GameObject myPlayerUnit;

    // Commands are a way to a client to send a msg to a server
    [Command]
    void CmdSpawnMyUnit() 
    {
        GameObject go = Instantiate(playerUnitPrefabObj);
       // myPlayerUnit = go;
       // go.GetComponent<NetworkIdentity>().AssignClientAuthority(connectionToClient);
        NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
    }

    [Command]
    void CmdChangePlayerName(string n) 
    {
        PlayerName = n;
        //RpcChangePlayerName(PlayerName);

    }

     /* [Command]
     void CmdMoveUnitUp() 
     {
         if (myPlayerUnit ==null)
         {
             return;
         }

         myPlayerUnit.transform.Translate(0,1,0);
     } */

     //RPC: functions only executed on clients

     /* [ClientRpc]
     void RpcChangePlayerName(string n)
     {
         PlayerName = n;
     }*/
}
