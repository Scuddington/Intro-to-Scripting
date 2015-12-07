using UnityEngine;
using System.Collections;

public class GuiManager : MonoBehaviour {

	public GameObject[] bullets;
	
	// Use this for initialization
	void Start () {
		GameManager.OnSpawnDucks = ResetBullets;
	}
	
	// Update is called once per frame
	public void DisableBullet(int index)
	{
		bullets[index].SetActive(false);
	}
	
	void ResetBullets()
	{
		foreach(GameObject bul in bullets)
		{
			bul.SetActive(true);
		}
	}
}
