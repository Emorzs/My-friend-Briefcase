using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class YellowPaper : MonoBehaviour
{
    public GameObject List;
    public GameObject ActiveWalls;
    public GameObject NotActivateWall;
    public GameObject Note;
    public Animator Anim;

    //«‚ÛÍ ÔÓ‰·Ó‡ ·ÛÏ‡ÊÍË
    [SerializeField] private AudioClip _takedpaper, _closenote;

    private void Start()
    {
        List.gameObject.SetActive(false);
        ActiveWalls.gameObject.SetActive(true);
        NotActivateWall.gameObject.SetActive(false);
        Note.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //«‚ÛÍ TakedPaper
        SoundManager.instance.PlaySound(_takedpaper);
        List.gameObject.SetActive(true);
        GameControlScript2.yellow += 1;
        //print(GameControlScript2.yellow);

        if (GameControlScript2.yellow % 2 > 0)
        {
            ActiveWalls.gameObject.SetActive(false);
            NotActivateWall.gameObject.SetActive(true);

        }
        if (GameControlScript2.yellow % 2 == 0)
        {
            ActiveWalls.gameObject.SetActive(true);
            NotActivateWall.gameObject.SetActive(false);
        }
        Note.gameObject.SetActive(true);
        Time.timeScale = 0;
        //Destroy(gameObject);

    }

    //œŒœ€“ ¿ ƒŒœ»—¿“‹  Œƒ
    //void OnTriggerExit(Collider2D col)
    //{
        //Destroy(Note);
        //Anim.SetTrigger("PickUp");
    //}

    public void PaperDestroy()
    {
        Destroy(gameObject);
    }

    public void ExitButton()
    {
        //«‚ÛÍ CloseNote
        SoundManager.instance.PlaySound(_closenote);
        Destroy(Note);
        Time.timeScale = 1;
        Anim.SetTrigger("PickUp");
    }


}