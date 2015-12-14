using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

	public static GUIManager instance;

	public Image bar;
	public float max_health = 100f;
	float cur_health = 0f;
	
	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = new GUIManager ();
		else if (instance != this)
			Destroy (this);

		cur_health = max_health;
		InvokeRepeating ("decreaseHealth", 0f, 2f);
	}

	public void decreaseHealth() {
		cur_health -= 20f;
		float calc_health = cur_health / max_health;
		SetHealthBar (calc_health);
	}

	public void SetHealthBar(float health)
	{
		Debug.Log ("where here");

		if (bar != null)
			bar.fillAmount = health;
		else
			Debug.Log ("Image not initialized");
	}
}