using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary> imports MonoBehaviour </summary>
public class characterControll : MonoBehaviour {

	///<summary> Executes att the start </summary>
	void Start () {

	}
		///<summary> Creates all necessary variables </summary>
    public float movementSpeed, mouseSpeed, rotationUppNer, lasvinkel, acceleration, hopphastighet;


    ///<summary> Executes every frame </summary>
    void Update () {
				///<summary> Gets CharacterController cc </summary>
        CharacterController cc = GetComponent<CharacterController>();

        ///<summary> Mouse movement X </summary>
        float rotationHogerVanster = Input.GetAxis("Mouse X") * mouseSpeed;
        transform.Rotate(0, rotationHogerVanster, 0);

				///<summary> Mouse movement Y </summary>
        rotationUppNer -= Input.GetAxis("Mouse Y") * mouseSpeed;
        rotationUppNer = Mathf.Clamp(rotationUppNer,-lasvinkel,lasvinkel);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationUppNer,0,0);

        ///<summary> Stabilization of kamera </summary>
        float speedForward = Input.GetAxis("Vertical") * movementSpeed;
        float speedSideStep = Input.GetAxis("Horizontal") * movementSpeed;

				///<summary> Applies Gravety </summary>
        acceleration += Physics.gravity.y * Time.deltaTime;

				///<summary> Jump funktion </summary>
        if (Input.GetButtonDown("Jump") && cc.isGrounded)
        {
            acceleration = hopphastighet;
        }

				///<summary> Create 3 Vectors </summary>
        Vector3 speed = new Vector3(speedSideStep, acceleration, speedForward);

        ///<summary> Rotation added to speed </summary>
        speed = transform.rotation * speed;

        ///<summary> Sets Character kontroll </summary>
        cc.Move(speed * Time.deltaTime);

    }
}
