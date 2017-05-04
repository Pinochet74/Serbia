using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Network1 : NetworkBehaviour {

	///<summary> Executes att the start </summary>
	void Start () {
				///<summary> Sets the conditions for action </summary>
        if (isLocalPlayer)
        {
						///<summary> Enableds alla other scripts </summary>
						GetComponent<characterControll>().enabled = true;
            GetComponent<bullet>().enabled = true;
            GetComponent<Granat>().enabled = true;
            GetComponent<PauseGame>().enabled = true;
        }
	}

}
