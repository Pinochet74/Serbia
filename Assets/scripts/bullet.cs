using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary> Imports the Prefabs</summary>
public class bullet : MonoBehaviour {
    public GameObject bullet_prefab;
    ///<summary>Creates new value</summary>
    public float bulletimpulse;


	///<summary> Update is called once per frame </summary>
	void Update () {
    ///<summary> Sets the conditions for action </summary>
		if(Input.GetButtonDown("Fire1"))
        {
            ///<summary>Executes action</summary>
            Camera cam = Camera.main;
            GameObject thebullet = (GameObject)Instantiate(bullet_prefab, cam.transform.position, cam.transform.rotation);
            thebullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletimpulse, ForceMode.Impulse);
        }
        if (Input.GetButtonDown("Cancel")) {

        }
	}
}
