﻿using UnityEngine;
using System.Collections;

public class MidTerm : MonoBehaviour {
	
	public int myInt = 6;
	float coffeeTemperature = 85.0f;
	private float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;
	int numEnemies = 3;
	private MidTerm myMidterm;
	public GameObject[] players;
	
	void Start ()
	{
		TemperatureTest();
		Debug.Log (myInt);
		
		for(int i = 0; i < numEnemies; i++)
		{
			Debug.Log("Creating enemy number: " + i);
		}
		myMidterm = GetComponent<MidTerm>();
		
		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}
		
		Direction myDirection;
		
		myDirection = Direction.North;
		
		ReverseDirection (myDirection);
		
	}
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		coffeeTemperature -= Time.deltaTime * 5f;
	}
	
	void TemperatureTest ()
	{
		string tooHot = "Coffee is too hot.";
		if(coffeeTemperature > hotLimitTemperature)
		{
			print(tooHot);
		}
	}
	
	enum Direction{North, East, South, West};
	
	void ReverseDirection (Direction dir)
	{
		if(dir == Direction.North)
			dir = Direction.South;
		
		
	}
	
	void Greet()
	{
		switch (myInt)
		{
		case 5:
			print ("Why hello there good sir! Let me teach you about Trigonometry!");
			break;
		case 4:
			print ("Hello and good day!");
			break;
		case 3:
			print ("Whadya want?");
			break;
		case 2:
			print ("Grog SMASH!");
			break;
		case 1:
			print ("Ulg, glib, Pblblblblb");
			break;
		default:
			print ("Incorrect intelligence level.");
			break;
		}
	}
	
	
}