using UnityEngine;
using System.Collections;

public class PitandPendulum : MonoBehaviour 
{
	public float SearchRoom = 15f;
	public float Rats = 50f;
	public float Pit = 25f;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			PitsandPendulums ();
		print ("Let's have a look around this black room");
		SearchRoom += Time.deltaTime * 5f;
	

		if (Input.GetKeyDown (KeyCode.S))
			print ("NO ONE EXPECTS THE SPANISH INQUISITION");
	}

	void PitsandPendulums()
	
	{
		if (SearchRoom < Pit) 
		{
			print ("OH NO A PIT");
		} 
		else if (SearchRoom > Rats) 
		{
			print ("AAAAHHHHH RATS");
		} 
		else 
		{
			print ("SHARP PENDULUM");
		}
	}
}
