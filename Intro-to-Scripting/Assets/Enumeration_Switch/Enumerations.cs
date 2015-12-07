using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour 
{
	//change constants in enum declaration
	//enum Direction {North = 10, East = 12, South = 14, West = 16};
	
//	enum Direction {North, East, South, West};
//	
//	void Start () 
//	{
//		Direction myDirection;
//		
//		myDirection = Direction.North;
//	}
//	
//	Direction ReverseDirection (Direction dir)
//	
//	{
//		if (dir == Direction.North)
//			dir = Direction.South;
//		else if (dir == Direction.South)
//			dir = Direction.North;
//		else if (dir == Direction.East)
//			dir = Direction.West;
//		else if (dir == Direction.West)
//			dir = Direction.East;
//			
//		return dir;
//	}

	enum Direction {North, East, South, Dennis};
	
	void Start()
	{
		Direction myDirection;
		myDirection = Direction.North;
	}
	
	Direction ReverseDirection (Direction dir)
	
	{
		if (dir == Direction.North)
			dir = Direction.South;
		else if (dir == Direction.South)
			dir = Direction.North;
		else if (dir == Direction.East)
			dir = Direction.Dennis;
		else if (dir == Direction.Dennis)
			dir = Direction.East;
			
		return dir;
	}
}
