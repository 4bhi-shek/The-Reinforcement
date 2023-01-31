using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointManager : MonoBehaviour
{

    //Refrence for GameObject/Prefab

    [SerializeField] GameObject zombie;


    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        int count = Random.Range(5, 10);
        //Clone Zombie 
        for (int i = 0; i < 10; i++)
        {
            GameObject g = Instantiate(zombie);
            // g.transform.parent = transform; // Same Output
            g.transform.position = new Vector3(Random.Range(410f, 425f), 97.314f, Random.Range(360f, 380f));
            //g.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

