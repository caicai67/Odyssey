/* 
 * This was super helpful:
 * http://slides.com/robinbaumgarten/arduino-unity3d/#/0/7
 */
using UnityEngine;
//using UnityEditor.Animations;
using System;
using System.IO.Ports;

public class ArduinoInput : MonoBehaviour {

	//public Animator stateAC;
	/*
	 * portname Make sure the name here is related to the port in the arduino app 
	 * (in this case the port was called "/dev/cu.usbmodem1421" in arduino and "/dev/tty.usbmodem1421" 
	 * in the terminal)
	 * To find the port in the terminal type "ls /dev/tty.*" to get a list of ports,
	 * and choose the one that is similar to the port in the arduino app.
	 * 
	 * baumspeed This speed is set in the "begin()" method of the arduino code (.ino)
	 * */
	SerialPort stream = new SerialPort("/dev/tty.usbmodem1421", 9600);

	void Start () 
	{
		stream.Open();
		stream.ReadTimeout = 100;
		 //Open the Serial Stream.
	}

	void Update () 
	{	
		

		try {
			string value = stream.ReadLine(); //Read the information
			//stateAC.SetBool("CirceLifted", value[0] == '0');
			//Debug.Log(stateAC.GetBool("CirceLifted"));
			Debug.Log (value);
		} catch {
			Debug.Log ("timed Out");
		}
		//string[] data = value.Split(','); 
		// ...
	}
	void OnDestroy() {
		stream.Close ();
	}
}

