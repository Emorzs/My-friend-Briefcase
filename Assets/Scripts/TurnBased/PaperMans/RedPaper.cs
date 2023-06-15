using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPaper : MonoBehaviour
{
    public GameObject ClearTrash;
    public GameObject ActivateWall;
    public GameObject NotActivateWall;
    public GameObject Note;
    public Animator Anim;

    //Звук подбора бумажки
    [SerializeField] private AudioClip _takedpaper, _closenote;

    private void Start()
    {
        ClearTrash.gameObject.SetActive(false);
        ActivateWall.gameObject.SetActive(true);
        NotActivateWall.gameObject.SetActive(false);
        Note.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Звук TakedPaper
        SoundManager.instance.PlaySound(_takedpaper);
        ClearTrash.gameObject.SetActive(true);
        GameControlScript2.red += 1;
        //print(GameControlScript2.red);
        //Destroy(gameObject);
        Note.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (GameControlScript2.red % 2 > 0)
        {
            ActivateWall.gameObject.SetActive(false);
            NotActivateWall.gameObject.SetActive(true);

        }
        if (GameControlScript2.red % 2 == 0)
        {
            ActivateWall.gameObject.SetActive(true);
            NotActivateWall.gameObject.SetActive(false);
        }
    }
    public void PaperDestroy()
    {
        Destroy(gameObject);
    }

    public void ExitButton()
    {
        //Звук CloseNote
        SoundManager.instance.PlaySound(_closenote);
        Destroy(Note);
        Time.timeScale = 1;
        Anim.SetTrigger("PickUp");
    }
}