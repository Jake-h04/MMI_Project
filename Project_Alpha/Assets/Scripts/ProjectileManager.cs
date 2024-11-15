using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    public GameObject[] projectilesPrefabs; 
    private int delayStart = 2;           
    public float spawnInterval = 1.5f;    

    public string spawnMangerTag = "SpawnManager";
    private GameObject taggedObject;              
    private Vector3 position;                     

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with the specified tag
        taggedObject = GameObject.FindWithTag(spawnMangerTag);

        if (taggedObject != null)
        {
            // Get its position
            position = taggedObject.transform.position;

            // Start spawning projectiles at regular intervals
            InvokeRepeating("SpawnProjectiles", delayStart, spawnInterval);
        }
        else
        {
            Debug.LogError("SpawnManager with tag '" + spawnMangerTag + "' not found!");
        }
    }

    void SpawnProjectiles()
    {
        if (projectilesPrefabs.Length > 0)
        {
            // Pick a random projectile from the array
            int projectileIndex = UnityEngine.Random.Range(0, projectilesPrefabs.Length);

            // Instantiate the selected projectile at the spawn position and rotation
            Instantiate(projectilesPrefabs[projectileIndex], position, projectilesPrefabs[projectileIndex].transform.rotation);
        }
        else
        {
            Debug.LogError("No projectiles assigned in the projectilesPrefabs array!");
        }
    }
}
