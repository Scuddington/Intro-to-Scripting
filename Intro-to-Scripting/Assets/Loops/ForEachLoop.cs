using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour 
{
	void Start ()
	{
		string[] weapons = new string[3];

		weapons[0] = "Pickaxe";
		weapons[1] = "Sword";
		weapons[2] = "Shovel";

		foreach (string item in weapons)
		{
			print (item);
		}
	}
}