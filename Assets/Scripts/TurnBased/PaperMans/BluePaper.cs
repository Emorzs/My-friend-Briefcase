using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePaper : MonoBehaviour
{
    public GameObject List;
    public GameObject ActiveWalls;
    public GameObject NotActivateWall;
    public GameObject Note;
    public Animator Anim;

    private void Start()
    {
        List.gameObject.SetActive(false);
        ActiveWalls.gameObject.SetActive(true);
        NotActivateWall.gameObject.SetActive(false);
        Note.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        List.gameObject.SetActive(true);
        GameControlScript2.blue += 1;
        //print(GameControlScript2.blue);

        if (GameControlScript2.blue % 2 > 0)
        {
            ActiveWalls.gameObject.SetActive(false);
            NotActivateWall.gameObject.SetActive(true);

        }
        if (GameControlScript2.blue % 2 == 0)
        {
            ActiveWalls.gameObject.SetActive(true);
            NotActivateWall.gameObject.SetActive(false);
        }

        Note.gameObject.SetActive(true);
        Time.timeScale = 0;
        //Destroy(gameObject);


    }
    public void PaperDestroy()
    {
        Destroy(gameObject);
    }

    public void ExitButton()
    {
        Destroy(Note);
        Time.timeScale = 1;
        Anim.SetTrigger("PickUp");
    }
}