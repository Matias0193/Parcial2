using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBoxes : MonoBehaviour
{
    public BulletPlayer bullet;
    Animator boxChange;
    float boxLife;
    void Start()
    {
        boxLife = 3;
        boxChange = GetComponent<Animator>();  
    }

    
    void Update()
    {
         if (boxLife >= 3)
        {
            boxChange.SetBool("Stade2", false);
            boxChange.SetBool("Stade3", false);
        }
        else if (boxLife == 2)
        {
            boxChange.SetBool("Stade2",  true);
            boxChange.SetBool("Stade3", false);
        }
        else if(boxLife == 1)
        {
            boxChange.SetBool("Stade3", true);
            boxChange.SetBool("Stade2", false);
        }
        else if(boxLife <= 0)
        {
            Destroy(this);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 11)
        {
            boxLife--;
            Destroy(collision.gameObject);
        }
    }
}
