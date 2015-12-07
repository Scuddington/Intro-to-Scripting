using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour 
{
	int numEnemies = 5;

	void Start ()
	{
		for (int i = 0; i < numEnemies; i++)
		{
			Debug.Log ("Creating Enemy Number: " + i);
		}
	}
}