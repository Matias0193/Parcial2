using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public int damage = 1;
    public int speed = 10;
    public float lifeTime;
    public string direction;

    void Start()
    {

    }

    
    void Update()
    {
        moveBullet();
        lifeTime += Time.deltaTime;
        if (lifeTime >= 5)
            Destroy(this.gameObject);
    }
    void moveBullet()
    {

        if (direction == "R")
            transform.position += transform.right * speed * Time.deltaTime;
        if (direction == "L")
            transform.position += -(transform.right) * speed * Time.deltaTime;
        if (direction == "U")
            transform.position += transform.up * speed * Time.deltaTime;
        if (direction == "D")
            transform.position += -(transform.up) * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 10)
            Destroy(gameObject);
    }
}
