using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;
    public void TakeDamage(float amount)
    {
        health -= amount;   
        if(health <= 0 )
        {
            
            Die();
        }

        void Die()
        {
            gameObject.SetActive(false);
           // Destroy(gameObject);
        }
    }


}
