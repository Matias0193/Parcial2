using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public BulletPlayer bulletBW;
    public float lifeBW;
    Animator animatorBW;
    Rigidbody2D bwipoRB;
    bool canMove;
    public float playerSpeed = 2;
    string viewBW;

    private void Awake()
    {
        animatorBW = GetComponent<Animator>();
        bwipoRB = GetComponent<Rigidbody2D>();
        canMove = true;
        lifeBW = 4f;
    }
    void Start()
    {

    }


    void Update()
    {
        
        if (lifeBW == 0)
        {
            Destroy(gameObject);
        }
        moveController();
        ShotBullet();   

    }

    void moveController()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-playerSpeed * Time.deltaTime, 0));
            viewBW = "L";
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(playerSpeed * Time.deltaTime, 0));
            viewBW = "R";
        }
        if (Input.GetKey("down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -playerSpeed * Time.deltaTime));
            viewBW = "D";
        }
        if (Input.GetKey("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, playerSpeed * Time.deltaTime));
            viewBW = "U";
        }
        var h = Input.GetAxis("Horizontal"); 
        var v = Input.GetAxis("Vertical"); 
        if (!canMove)
        {
            h = 0;
            v = 0;
        }

        if (h != 0 || v != 0)
        {
            animatorBW.SetBool("Walk", true);
        }

        else
        {
            animatorBW.SetBool("Walk", false);
        }

        animatorBW.SetFloat("Horizontal", h);
        animatorBW.SetFloat("Vertical", v);

        Vector2 direction = new Vector2(h, v);
        bwipoRB.MovePosition(bwipoRB.position + direction.normalized * playerSpeed * Time.fixedDeltaTime);
    }
    private void OnCollisionEnter2D(Collision2D enemyCollision)
    {
        if (enemyCollision.gameObject.layer == 10)
        {
            lifeBW--;
            Debug.Log(lifeBW);
        }
    }
    void ShotBullet()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
         var bullet = Instantiate(bulletBW, transform.position, transform.rotation);
        bullet.direction = viewBW;
        bullet.speedBullet = 5;
        bullet.lifeBullet = 4;
        }
    }
}
