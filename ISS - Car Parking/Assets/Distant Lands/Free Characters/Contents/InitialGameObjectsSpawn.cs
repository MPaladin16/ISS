using UnityEngine;
using System.Collections;

public class InitialGameObjectsSpawn : MonoBehaviour
{
	// javne variable

	public float xMinRange = -4.0f;
	public float xMaxRange = 4.0f;
	public float yMinRange = 0.0f;
	public float yMaxRange = 0.0f;
	public float zMinRange = -100.0f;
	public float zMaxRange = 100.0f;
	public float numberOfEnemies = 20.0f;
	public float timeToPoplulateLevel = 3.0f;
	public GameObject[] spawnObjects; // what prefabs to spawn

	//privatne variable
	private float nextSpawnTime;
	private float secondsBetweenSpawning;


	// Inicijalizacija
	void Start ()
	{	// definicija vremena za instanciranje sljedećeg objekta (u koliko vremena se svi insanciraju)
		secondsBetweenSpawning = timeToPoplulateLevel / numberOfEnemies;
		nextSpawnTime = Time.time+secondsBetweenSpawning;
	}
	
	// Ova funkcija se poziva jednom po okviru
	void Update ()
	{
		//jesu li svi neprijatelji kreirani? ako nisu provjeri treba li novog
		if (numberOfEnemies>0){
		// je li vrijeme za generiranje novog neprijatelja
			if (Time.time >= nextSpawnTime) {
				// Spawn the game object through function below
				MakeThingToSpawn ();
				//reduce the number of enemies
				numberOfEnemies = numberOfEnemies - 1;

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
