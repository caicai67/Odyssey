/* ArduinoConnector by Alan Zucconi
 * http://www.alanzucconi.com/?p=2979
 */
using UnityEngine;
using System.IO.Ports;

public class ArduinoInput : MonoBehaviour {
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
		stream.ReadTimeout = 50;
		stream.Open(); //Open the Serial Stream.
	}

	void Update () 
	{
		string value = stream.ReadLine(); //Read the information
		Debug.Log(value);
		//string[] data = value.Split(','); 
		// ...
	}
}

