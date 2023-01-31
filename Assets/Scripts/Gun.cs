using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Gun : MonoBehaviour
{
    public float damage = 20f;
    public float range = 100f;
    public float fireRate = 15f;
    public GameObject gunPoint;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect, bloodEffect, dustEffect;
    // public GameObject gameObject;
    public Camera mainCamera;

    private int maxAmmo = 10;
    private int currentAmmo;
    public float reloadTime = 1f;
    private bool isRelaoding = false;
    public AudioSource gunReload;
    public AudioClip reloadClip;


    public AudioClip singleShot;
    public AudioSource gunShot;

    private float nextTimeToFire = 0;

    public Animator animator;

    private void Start()
    {
        mainCamera = Camera.main;
        //currentAmmo = maxAmmo;
    }

    private void OnEnable()
    {
        isRelaoding = false;
        animator.SetBool("Reloading", false);
    }
    private void Update()
    {
        if (isRelaoding)
            return;

        if (currentAmmo <=  0 || Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reload());
            gunReload.PlayOneShot(reloadClip);

            return;
        }

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire) 
        {
            nextTimeToFire = Time.time + 1f/fireRate;
            Shoot();
            gunShot.PlayOneShot(singleShot);

        }
    }

    IEnumerator Reload()
    {
        isRelaoding = true;

        animator.SetBool("Reloading", true);

        Debug.Log("Relaoding.....");

       /* if (maxAmmo > 0)
        {
            currentAmmo = 12;
            maxAmmo -= 12;
        }
        else
            Debug.Log("No ammoleft");*/
        

        yield return new WaitForSeconds(reloadTime - .25f);
        animator.SetBool("Reloading", false);
        yield return new WaitForSeconds(.25f);

        currentAmmo = maxAmmo;
        
        isRelaoding=false;
    }    

    void Shoot()
    {

        muzzleFlash.Play();

        currentAmmo--;

        RaycastHit hit;

        if(Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Health enemy = hit.transform.GetComponent<Health>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            
            // using Raycast to Detect the Collider
            if(hit.transform.name == "Enemy")
            {
                GameObject bloodGO = Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(bloodGO, 0.5f);
                
            }
            else if(hit.transform.name == "Forest")
            {
                GameObject dustGo = Instantiate(dustEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(dustGo, 0.5f);
            }

            else
            {
                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 0.5f);
            }
                
            
            
            
           
        }
    }

}
