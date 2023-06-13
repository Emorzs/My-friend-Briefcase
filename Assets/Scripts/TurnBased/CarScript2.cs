using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript2 : MonoBehaviour
{
    public GameObject List1;
    public GameObject Car1, Car2, Car3;


    //public int c1 = 0;
    //public int c2 = 0;

    //public GameObject[] CarsOff;
    //public Animator Anim;
    private void Start()
    {
        List1.gameObject.SetActive(false);
        Car1.gameObject.SetActive(false);
        Car2.gameObject.SetActive(true);
        Car3.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //GameControlScript.steps += 4;
        List1.gameObject.SetActive(true);
        //c1++;
        GameControlScript2.yellow += 1;
        //GameControlScript2.FindObjectOfType(Car1).gameObject.SetActive(true);

        if (GameControlScript2.yellow % 2 > 0)
        {
            Car1.gameObject.SetActive(true);
            Car2.gameObject.SetActive(false);
            Car3.gameObject.SetActive(true);

        }
        if (GameControlScript2.yellow % 2 == 0)
        {
            Car1.gameObject.SetActive(false);
            Car2.gameObject.SetActive(true);
            Car3.gameObject.SetActive(false);
        }
        Destroy(gameObject);

        //CarsChange;
        //Anim.SetTrigger("PickUp");

    }

    //public void CarsChange()
    //{
    //Car1.SetActive(false);
    //}
    //public void PaperDestroy ()
    //{
    //Destroy(gameObject);
    //}
}