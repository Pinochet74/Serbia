# Serbia
Contribute
----------
You can contribute bye fixing the grenade Bugg and expand the network functions

Upcoming features
--------
- Grenade bugg will be Fixed
- Network functions will be expanded on
- more maps will be added

Code example
-------
here some code from characterControll.cs

        ///<summary> Mouse movement X </summary>
        float rotationHogerVanster = Input.GetAxis("Mouse X") * mouseSpeed;
        transform.Rotate(0, rotationHogerVanster, 0);

				///<summary> Mouse movement Y </summary>
        rotationUppNer -= Input.GetAxis("Mouse Y") * mouseSpeed;
        rotationUppNer = Mathf.Clamp(rotationUppNer,-lasvinkel,lasvinkel);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationUppNer,0,0);

Support
-------
If you are having issues, please let me know at luis.daniel.0919@gmail.com

License
-------
The project is licensed under the GNU General Public License v3.0license.
