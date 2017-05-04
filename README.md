# Serbia
An FPS game made for a school project. with a balkan theme and some simple funktion.
The game si not done but it will be uppdate later on. The game is done enougth to so you
can try it out.

Features
--------
- Basic movement dunction
- Basic fire and grenade funktions
- Basic networking function
- Pause function
- Simple particle effects

Set up
------------
  1.import project
  2.run it in Unity 5.5.1f1
  you can also just run the .exe if you only want to play

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
