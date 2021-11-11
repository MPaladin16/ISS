using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int Spawnrate = 100; // 2 sec
    public GameObject[] spawnObjects;
    private int brojac = 0;
    public Vector3[] spawnPlace;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        brojac++;
        if (brojac == Spawnrate) {

            int objectToSpawn = Random.Range(0, spawnObjects.Length);
            int placeToSpawn = Random.Range(0, spawnPlace.Length);

            if (spawnPlace[placeToSpawn].z == 40)
            {
                GameObject spawnedObject = Instantiate(spawnObjects[objectToSpawn], spawnPlace[placeToSpawn], transform.rotation * Quaternion.Euler(0f, 180f, 0f)) as GameObject;
                spawnedObject.transform.parent = gameObject.transform;
            }
            else
            {
                GameObject spawnedObject = Instantiate(spawnObjects[objectToSpawn], spawnPlace[placeToSpawn], transform.rotation) as GameObject;
                spawnedObject.transform.parent = gameObject.transform;
            }
            brojac = 0;
        }
    }
}
