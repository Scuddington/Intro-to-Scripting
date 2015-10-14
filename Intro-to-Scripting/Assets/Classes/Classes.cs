using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour 
{
	public class Stuff
	{
		public int bullets;
		public int grenades;
		public int rockets;
		public int fuel;
		
		public Stuff (int bul, int gre, int roc)
		
		{
			bullets = bul;
			grenades = gre;
			rockets = roc;
		}
		
		public Stuff ()
		
		{
			bullets = 50;
			fuel = 20;
			rockets = 3;
		}
		
		
	}
	
	public Stuff myStuff = new Stuff(10, 7, 25);
	public float speed;
	public float turnSpeed;
	public Rigidbody bulletPrefab;
	public Transform firePosition;
	public float bulletSpeed;
	
	
}
