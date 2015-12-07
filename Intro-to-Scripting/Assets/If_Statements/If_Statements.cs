using UnityEngine;
using System.Collections;

public class If_Statements : MonoBehaviour 
{
	float coffeeTemperature = 85.0f;
	float hotLimitTemperature = 70f;
	float coldLimitTemperature = 40f;


	// Use this for initialization
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest();

		coffeeTemperature -= Time.deltaTime * 5f;
	
	}

	void TemperatureTest ()
	{
		if (coffeeTemperature > hotLimitTemperature) {
			print ("TOO HOT");
		} 

		else if (coffeeTemperature < coldLimitTemperature) {
			print ("No one likes lukewarm coffee");
		} 

		else 
		{
			print ("Goldilocks would be proud");
		}
	}
}
