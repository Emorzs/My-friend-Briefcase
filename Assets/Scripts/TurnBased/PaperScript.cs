using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PaperScript : MonoBehaviour
{

    public GameObject List;
    public GameObject Wall;
    public GameObject Note;
    public Animator Anim;
    private void Start()
    {
        List.gameObject.SetActive(false);
        Wall.gameObject.SetActive(false);
        Note.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //GameControlScript.steps += 4;
        List.gameObject.SetActive(true);
        Wall.gameObject.SetActive(true);
        //Anim.SetTrigger("PickUp");

        //œŒœ€“ ¿ ƒŒ¡¿¬»“‹ œŒﬂ¬À≈Õ»≈ «¿œ»— »
        Note.gameObject.SetActive(true);
        
    }
    public void PaperDestroy ()
    {
        Destroy(gameObject);
    }

    public void ExitButton()
    {
        Destroy(Note);
        Anim.SetTrigger("PickUp");
    }
}
