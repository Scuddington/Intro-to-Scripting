using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		bool shouldContinue = false;

		do
		{
			print ("OOGA BOOGA BOOGA");
		}while(shouldContinue == true);
	}


}
