using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public enum deathAction {loadLevelWhenDead,doNothingWhenDead};
	
	public float healthPoints = 1f;
	public float respawnHealthPoints = 1f;		//base health points
	
	public int numberOfLives = 1;                   //lives and variables for respawning
    public bool isAlive = true;

	public GameObject camera1;
	public GameObject camera2;

	public GameObject explosionPrefab;
	
	public deathAction onLivesGone = deathAction.doNothingWhenDead;
	
	public string LevelToLoad = "";
	
	private Vector3 respawnPosition;
	private Quaternion respawnRotation;
	

	// Use this for initialization
	void Start () 
	{
		// store initial position as respawn location
		respawnPosition = transform.position;
		respawnRotation = transform.rotation;
			camera1.SetActive(true);
			camera2.SetActive(false);

		if (LevelToLoad=="") // default to current scene 
		{
			LevelToLoad = Application.loadedLevelName;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (healthPoints <= 0) {				// if the object is 'dead'
			numberOfLives--;
			camera2.SetActive(true);
			camera1.SetActive(false);
			
			while (true)
			{
				if (Input.GetKeyDown("space"))
				{
					break;
				}

			}
			if (explosionPrefab!=null) {
				Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			}
			
			if (numberOfLives > 0) { // respawn
				transform.position = respawnPosition;	// reset the player to respawn position
				transform.rotation = respawnRotation;
				healthPoints = respawnHealthPoints;	// give the player full health again
			} else { // here is where you do stuff once ALL lives are gone)
				isAlive = false;
				
				switch(onLivesGone)
				{
				case deathAction.loadLevelWhenDead:
							Application.LoadLevel(LevelToLoad);
							break;
				case deathAction.doNothingWhenDead:
					// do nothing, death must be handled in another way elsewhere
					break;
				}
				Destroy(gameObject);
			}
		}
	}
	
	
	public void ApplyDamage(float amount)
	{	
		healthPoints = healthPoints - amount;	
	}
	
	public void ApplyHeal(float amount)
	{
		healthPoints = healthPoints + amount;
	}

	public void ApplyBonusLife(int amount)
	{
		numberOfLives = numberOfLives + amount;
	}
	
	public void updateRespawn(Vector3 newRespawnPosition, Quaternion newRespawnRotation) {
		respawnPosition = newRespawnPosition;
		respawnRotation = newRespawnRotation;
	}
}
