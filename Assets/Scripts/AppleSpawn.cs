using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawn : MonoBehaviour
{
    public GameObject applePrefab;
    public float spawnDelay = 1f;

    IEnumerator SpawnApple()
    {
        while(true)
        {
            float randomXposition = Random.Range(-8f, 8f);
            Vector3 spawnPosition = new Vector3(x: randomXposition, y: 6f, z: 0);
            Instantiate(applePrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnDelay);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnApple());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
