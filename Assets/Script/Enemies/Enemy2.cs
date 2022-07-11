using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public BulletEnemy bulletEnemy;
    PlayerController bwipoSC;
    float distanceFbwipo;
    float enemySpeed = 2;
    float distanceMn = 5;
    bool canShoot;
    
    public float life = 2;

    
    private void Awake()
    {
        canShoot = false;   
        bwipoSC = FindObjectOfType<PlayerController>();

    }
    void Start()
    {

    }
    void Update()
    {
        ShootToPlayer();   
        LookAtPlayer();

    }
    void CheckDistanceFromPlayer()
    {
        distanceFbwipo = Vector2.Distance(transform.position, bwipoSC.transform.position);
    }
    void ShootToPlayer()
    {
        CheckDistanceFromPlayer();
        if (canShoot == false)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    canShoot = true;
                }
            }
        }
        if (canShoot == true)
        {
            if (distanceFbwipo <= distanceMn)
            {
                Instantiate(bulletEnemy, transform.position, transform.rotation);
            }
            canShoot=false;
        }
         

    }


    void LookAtPlayer()
    {
        Vector3 lookAt = bwipoSC.transform.position - transform.position;
        transform.up = lookAt;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D bulletCollision)
    {
        if (bulletCollision.gameObject.layer == 11)

        {
            life--;
            if (life <= 0)
            {
                Destroy(gameObject);
            }
            Destroy(bulletCollision.gameObject);
            Debug.Log("colision");
        }
    }
}
