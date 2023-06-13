using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeScript : MonoBehaviour

{
    
    void OnTriggerEnter2D(Collider2D col)
    {
        GameControlScript2.steps += 4;
        GameObject.Destroy(gameObject);
        //GetComponent<CoffeeScript>().enabled = false;
        
        
        //GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }


    //public LayerMask BuffCoffee;

    //void Update()
    //{
        //if (Physics2D.OverlapCircle( + Vector3.left, .2f, BuffCoffee))
        //{
            //GameControlScript.steps += 3;
        //}
    //}

}
