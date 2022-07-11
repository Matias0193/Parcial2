using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    PlayerController bwipoSC;
    float distanceFbwipo;
    float enemySpeed = 2;
    float distanceMn = 5;
    public float life = 4;

    

    private void Awake()
    {

        bwipoSC = FindObjectOfType<PlayerController>();

    }
    void Start()
    {

    }
    void Update()
    {
        MoveToPlayer();
        LookAtPlayer();

    }
    void CheckDistanceFromPlayer()
    {
        distanceFbwipo = Vector2.Distance(transform.position, bwipoSC.transform.position);
    }

    void MoveToPlayer()
    {
        CheckDistanceFromPlayer();
        if (distanceFbwipo <= distanceMn)
        {
            transform.position += transform.up * enemySpeed * Time.deltaTime;

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
