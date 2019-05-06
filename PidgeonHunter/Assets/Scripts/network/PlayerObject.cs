using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour
{ 
    public GameObject playerUnitPrefabObj;

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
    }

    //GameObject myPlayerUnit;


    [Command]
    void CmdSpawnMyUnit() 
    {
        GameObject go = Instantiate(playerUnitPrefabObj);
       // myPlayerUnit = go;
       // go.GetComponent<NetworkIdentity>().AssignClientAuthority(connectionToClient);
        NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
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
}
