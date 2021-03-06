﻿using UnityEngine;
using System.Collections;

public class DirectionChange : MonoBehaviour {

	public enum Changer {Horizontal, Vertical};

	public Changer changer;
	
	void OnCollisionEnter (Collision hit) 
	{
		if(hit.transform.tag == "Duck")
		{
			DuckMove movement = hit.gameObject.GetComponent<DuckMove>();
			if(changer == Changer.Horizontal)
			{
				movement.DirectionChanger(new Vector3 (-1, 1, 0));
			}
			else if(changer == Changer.Vertical)
			{
				movement.DirectionChanger(new Vector3 (1, -1, 0));
			}
		}
	}
}
