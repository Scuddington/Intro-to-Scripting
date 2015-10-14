using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 
{
	int CupsInTheSink = 4;
	
	
	// Use this for initialization
	void Start () 
		
	{
		while (CupsInTheSink > 0)
		{
			Debug.Log ("I washed a cup!");
			CupsInTheSink--;
		}
	}
}
