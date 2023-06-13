using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject List;
    public GameObject RedBoxes;

    private void Start()
    {
        List.gameObject.SetActive(false);
        RedBoxes.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        List.gameObject.SetActive(true);
        //c1++;
        GameControlScript2.red += 1;
        print(GameControlScript2.red);
        //GameControlScript2.FindObjectOfType(Car1).gameObject.SetActive(true);


        Destroy(gameObject);

        //CarsChange;
        //Anim.SetTrigger("PickUp");

    }

    private void Update()
    {
        if (GameControlScript2.red % 2 > 0)
        {
            RedBoxes.gameObject.SetActive(true);

        }
        if (GameControlScript2.red % 2 == 0)
        {
            RedBoxes.gameObject.SetActive(false);
        }
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