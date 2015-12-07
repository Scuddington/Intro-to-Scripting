using UnityEngine;
using System.Collections;

public class Switches : MonoBehaviour {

	public int clearance = 5;
	
	void Start()
	
	{
		switch (clearance)
		{
			case 5:
				print ("All your base are belong to us");
				break;
			case 4:
				print ("You have no chance to survive make your time");
				break;
			case 3:
				print ("Somebody set us up the bomb");
				break;
				
				default:
				print ("whatever");
				break;
				
		}
	}
}
