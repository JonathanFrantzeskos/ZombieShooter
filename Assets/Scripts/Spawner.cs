using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float spawnInterval = 3f;
    private float timer = 0f;
    private GameObject zombie;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnZombie();
            timer = 0f;
        }
    }
    void SpawnZombie()
    {
        GameObject zombie = Instantiate(zombiePrefab, transform.position, Quaternion.identity);
        
        Destroy(zombie,5f); 
    }

   /* private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag =="Bullet")
        {
            Destroy(zombie);
        }
        if(other.tag == "House"){
            Destroy(zombie);
        }
}*/
    

    
}
