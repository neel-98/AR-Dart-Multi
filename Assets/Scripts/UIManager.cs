using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;
using GoogleARCore.Examples.CloudAnchors;

public class UIManager : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NetworkServer.connections.Count == 1){
            GameObject.Find("LocalPlayer").GetComponent<LocalPlayerController>().setColorToBlue(true);
            return;
        }
        if(NetworkServer.connections.Count == 2)
        {
            GameObject.Find("LocalPlayer (1)").GetComponent<LocalPlayerController>().setColorToBlue(false);
            return;
        }
    }
}
