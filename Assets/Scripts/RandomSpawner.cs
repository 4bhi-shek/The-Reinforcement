using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] zombie;
    [SerializeField] Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerTransform.position);
       if(distance <= 5f)
        {
            int randomIndex = Random.Range(0, zombie.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(400, 420), 94, 344);

            GameObject zombies = ZombiePooler.instance.GetPooledObject();

            if(zombies != null)
            {
                zombies.transform.position = randomSpawnPosition;
                zombies.SetActive(true);
            }
            //Instantiate(zombie[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }


}
