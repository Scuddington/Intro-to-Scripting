using UnityEngine;
using System.Collections;

public class SpawnDuck : MonoBehaviour {

	public GameObject duck;

	public void DuckSpawn()
	{
		Instantiate (duck, transform.position, Quaternion.identity);
	}
}
