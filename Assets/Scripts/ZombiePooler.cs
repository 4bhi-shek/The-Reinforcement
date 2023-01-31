using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePooler : MonoBehaviour
{
    public static ZombiePooler instance;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 2;

    [SerializeField] private GameObject zombiePrefab;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject go = Instantiate(zombiePrefab);
            go.SetActive(false);
            pooledObjects.Add(go);
        }
    }

    public GameObject GetPooledObject()
    {
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}