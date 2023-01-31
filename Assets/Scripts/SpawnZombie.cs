using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnZombie : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    [SerializeField] Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, playerTransform.position);
        if (distance <= 5f)
        {
            StartCoroutine(Spawn());
        }

        
    }

    IEnumerator Spawn()
    {
        GameObject g = Instantiate(zombie);


        g.transform.position = transform.position;

        yield return new WaitForSeconds(15f);
    }
}
