using UnityEngine;
using System.Collections;
using System.Collections.Generic;

///<summary> Imports the Audio and Prefabs </summary>
public class Granat : MonoBehaviour {
	public GameObject granat_prefab;
	public float granatimpulse;
	public AudioClip shootSound;

	private AudioSource source;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;

///<summary> Gets AudioSource</summary>
	void Awake () {
		source = GetComponent<AudioSource>();
	}

	///<summary> Update is called once per frame </summary>
	void Update () {
		///<summary> Sets the conditions for action </summary>
		if (Input.GetButtonDown ("Fire2"))
		{
			///<summary>Executes action</summary>
			float vol = Random.Range (volLowRange, volHighRange);
			source.PlayOneShot (shootSound, vol);
			Camera cam = Camera.main;
			GameObject thegranat = (GameObject)Instantiate(granat_prefab, cam.transform.position, cam.transform.rotation);
			thegranat.GetComponent<Rigidbody>().AddForce(cam.transform.forward * granatimpulse, ForceMode.Impulse);
		}
	}
}
