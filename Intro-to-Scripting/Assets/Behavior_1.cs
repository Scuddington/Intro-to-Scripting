using UnityEngine;
using System.Collections;

public class Behavior_1 : MonoBehaviour {


	int myInt = 55;

	void Start (){
		myInt = AddTwo(myInt);
		Debug.Log (myInt);
	}
	
	int AddTwo (int number)
	{
		int ret;
		ret = number + 2;
		return ret;
	}
}
