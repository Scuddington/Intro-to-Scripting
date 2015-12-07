using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	
	RaycastHit hit;
	
	private int bulletAmount;
	public int maxBullets;
	
	
	void Start () 
	{
		GameManager.OnSpawnDucks += ResetBullets;
	}
	
	
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			bulletAmount--;
			if (bulletAmount <= 0)
			{
				GameManager.OnDuckMiss();
			}
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;
			
			if(Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
			{
				if(hit.transform.tag == "Duck")
				{
					GetComponent<DuckHealth>();
					print ("WHAT THE DUCK, MAN?!");
				}
			}
		}
	}
			
			public void ResetBullets()
			{
				bulletAmount = maxBullets;
			}
}