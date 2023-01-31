using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RadioDestroyer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject radio;
    

    
   
    void Update()
    {
        float distance =  Vector3.Distance (transform.position, player.transform.position);

        if(distance <= 2 && Input.GetKeyDown(KeyCode.F))
        {
            
            Destroy(radio, 120f);
            
        }
    }
}
