using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] Health healthScript;
    [SerializeField] BoxCollider leftArmColl;
    GameObject target;
    public Animator zombAnim;
    float distance;
    
   
    // Start is called before the first frame update
    void Start()
    {
        //leftArmColl = GetComponent<BoxCollider>();
        target = GameObject.FindGameObjectWithTag("Player");
        //healthScript = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
      distance = Vector3.Distance(transform.position, target.transform.position);
      Movement();

    }
 

    public void Movement()
    {
            if (distance >= 10f)
            {
                zombAnim.SetBool("Walk", true);
                zombAnim.SetBool("Run", false);
                zombAnim.SetBool("Attack", false);
            }
            else if (distance < 10f && distance >= 5f)
            {
                zombAnim.SetBool("Run", true);
                zombAnim.SetBool("Walk", false);
                zombAnim.SetBool("Attack", false);
            }
            else if (distance < 2f)
            {
                zombAnim.SetBool("Attack", true);
                
            }   
    }
    
    /* public void DamagePlayer()
    {
        Health player = GetComponent<Health>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }*/


}

