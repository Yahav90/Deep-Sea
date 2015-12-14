using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private float maxHealth = 100f;
	bool unTouchable = false;

	[System.Serializable]  
	public class PlayerStats {
		public float health = 100f;
	}

	public static PlayerStats playerStats;


	void Start() {
		playerStats = new PlayerStats();
	}

	public void DamagePlayer (float damage) {

		playerStats.health -= damage;
		Debug.Log(damage);
		Debug.Log(playerStats.health);

		if (playerStats.health <= 0) {
			GameManager.KillPlayer(this);
		}
	}

	public void RevivePlayer (float revive) {

		if (playerStats.health <= maxHealth) {
			playerStats.health += revive;
		}
	}
	
	// Update is called once per frame
	void Update () {

		// When to damage the player. when enemy hits me - rigidbody. 
		if (Input.GetKeyDown(KeyCode.Space)) {
			DamagePlayer(100);
		}
	}
}
