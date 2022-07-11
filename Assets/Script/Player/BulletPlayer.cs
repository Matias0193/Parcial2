using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    
    float lifeTimeBullet;
    public float speedBullet;
    public float lifeBullet;
    public string direction;

    private void Start()
    {
        speedBullet = 5;
        lifeBullet = 4;
    }

    void Update()
    {
        transform.position += transform.up * speedBullet * Time.deltaTime;

        lifeTimeBullet += Time.deltaTime;
        if (lifeTimeBullet >= lifeBullet)
        {
            Destroy(gameObject);
        }
        bulletDirection();
        
    }

    private void OnTriggerEnter2D(Collider2D wallCollision)
    {
        if (wallCollision.gameObject.layer == 6)
        {
            Destroy(gameObject);
        }
        
    }
    void bulletDirection()
    {

        if (direction == "R")
            transform.position += transform.right * speedBullet * Time.deltaTime;
        if (direction == "L")
            transform.position += -(transform.right) * speedBullet * Time.deltaTime;
        if (direction == "U")
            transform.position += transform.up * speedBullet * Time.deltaTime;
        if (direction == "D")
            transform.position += -(transform.up) * speedBullet * Time.deltaTime;
    }
}
