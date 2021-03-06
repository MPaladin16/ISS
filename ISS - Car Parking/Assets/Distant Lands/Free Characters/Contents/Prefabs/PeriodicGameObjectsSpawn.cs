using UnityEngine;
using System.Collections;

public class PeriodicGameObjectsSpawn : MonoBehaviour
{
	// javne varijable

	public float xMinRange = -3.0f;
	public float xMaxRange = 3.0f;
	public float yMinRange = 10.0f;
	public float yMaxRange = 10.0f;
	public float zMinRange = -100.0f;
	public float zMaxRange = 100.0f;
	public float numberOfEnemies = 10.0f;
	public float concurentActiveEnemies = 3.0f;
	public float secondsBetweenSpawning = 3.0f;

	public GameObject[] spawnObjects; // what prefabs to spawn

	//Privatne varijable
	private float nextSpawnTime;

	// Inicijalizacija
	void Start ()
	{	// definicija vremena za instanciranje sljedećeg objekta 
		nextSpawnTime = Time.time+secondsBetweenSpawning;
	}
	
	// Ova funkcija se poziva jednom po okviru
	void Update ()
	{
		//jesu limit neprijatelja dostignut (gleda se broj djece objekta koji sadri skriptu)
		if (transform.childCount<numberOfEnemies){
		// je li vrijeme za generiranje novog neprijatelja
			if (Time.time >= nextSpawnTime) {
				// Spawn the game object through function below
				MakeThingToSpawn ();
					// definicija sljedećeg termina generiranja objekta
				nextSpawnTime = Time.time + secondsBetweenSpawning;
			}
		}	
	}

	void MakeThingToSpawn ()
	{
		Vector3 spawnPosition;

		// generiranje slučajne varijable pozicije
		spawnPosition.x = Random.Range (xMinRange, xMaxRange);
		spawnPosition.y = Random.Range (yMinRange, yMaxRange);
		spawnPosition.z = Random.Range (zMinRange, zMaxRange);

		// slučajno generiranje objekta koji će se pojaviti
		int objectToSpawn = Random.Range (0, spawnObjects.Length);

		// instanciranje objekta
		GameObject spawnedObject = Instantiate (spawnObjects [objectToSpawn], spawnPosition, transform.rotation) as GameObject;

			// postavljanje objekta spawnera kao roditelja kreiranog objekta (čuvamo hijerarhiju čistom)
		spawnedObject.transform.parent = gameObject.transform;
	}
}
