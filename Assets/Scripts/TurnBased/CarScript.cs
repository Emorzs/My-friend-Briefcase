using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{

    public GameObject List1;
    public GameObject Car1, Car2, Car3, Car4;
    //public int c1 = 0;
    //public int c2 = 0;

    //public GameObject[] CarsOff;
    //public Animator Anim;
    private void Start()
    {
        List1.gameObject.SetActive(false);
        Car1.gameObject.SetActive(true);
        Car2.gameObject.SetActive(false);
        Car3.gameObject.SetActive(true);
        Car4.gameObject.SetActive(true);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //GameControlScript.steps += 4;
        List1.gameObject.SetActive(true);
        //c1++;
        GameControlScript2.blue += 1;
        //GameControlScript2.FindObjectOfType(Car1).gameObject.SetActive(true);

        if (GameControlScript2.blue % 2 > 0)
        {
            Car1.gameObject.SetActive(false);
            Car2.gameObject.SetActive(true);
            Car3.gameObject.SetActive(false);
            Car4.gameObject.SetActive(false);
        }
        if (GameControlScript2.blue % 2 == 0)
        {
            Car1.gameObject.SetActive(true);
            Car2.gameObject.SetActive(false);
            Car3.gameObject.SetActive(true);
            Car4.gameObject.SetActive(true);
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
