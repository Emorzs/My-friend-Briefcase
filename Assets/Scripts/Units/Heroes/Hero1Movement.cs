using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Hero1Movement : MonoBehaviour
{
    public static bool isMoving;
    private Vector2 origPos, targetPos;

    private float timeToMove = 0.3f;

    public LayerMask whatStopMovement;
    //ќбъ€вл€ю аниматор
    public Animator Anim;

    Vector2 movement;

    //private float run;

    private void Start()
    {
        Time.timeScale = 1;
        isMoving = false;
    }

    private void ResetAnim()
    {
        Anim.SetFloat("Vertical", 0);
        Anim.SetFloat("Horizontal", 0);
    }

    void Update()
    {
        //Anim.SetFloat("Vertical", 0);
        //Anim.SetFloat("Horizontal", 0);

        //Anim.SetBool("StillMoving", isMoving);

        /*if (!isMoving)
        {
            Anim.SetFloat("Vertical", 0);
            Anim.SetFloat("Horizontal", 0);
        }
        */

        //run = 0;
        //print(run);

        //Anim.SetBool("StillMoving", true);

        //run = timeToMove * Time.timeScale;

        /*
        if (Input.GetKey(KeyCode.A))
        {
            if (!Physics2D.OverlapCircle(targetPos + Vector2.left, .2f, whatStopMovement))
            {
                StartCoroutine(MoveBob(Vector2.left));
                GameControlScript2.steps -= 1;
                Anim.SetFloat("Horizontal", -1);

                Anim.SetFloat("Vertical", 0);
            }
        }
        */


        if (isMoving)
            return;

        if (Input.GetKey(KeyCode.W))
        {
            InputHandler(Vector2.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            InputHandler(Vector2.left);
        }

        if (Input.GetKey(KeyCode.S))
        {
            InputHandler(Vector2.down);
        }

        if (Input.GetKey(KeyCode.D))
        {
            InputHandler(Vector2.right);
        }


        //if (isMoving = false)
        //{
            //Anim.SetFloat("Speed", 0);
        //}



        //{
            //if (Input.GetKey(KeyCode.A) && !isMoving)
            //StartCoroutine(MoveBob(Vector3.left));

            //if (Input.GetKey(KeyCode.S) && !isMoving)
            //StartCoroutine(MoveBob(Vector3.down));

            //if (Input.GetKey(KeyCode.D) && !isMoving)
            //StartCoroutine(MoveBob(Vector3.right));
        //}
    }

    private void InputHandler(Vector2 input)
    {
        if (!Physics2D.OverlapCircle(targetPos + input, .2f, whatStopMovement))
        {
            StartCoroutine(MoveBob(input));
            GameControlScript2.steps -= 1;
            //run= 1;
            Anim.SetFloat("Horizontal", input.x);
            Anim.SetFloat("Vertical", input.y);
        }
    }

    private IEnumerator MoveBob (Vector2 direction)
    {
        isMoving = true;
        Anim.SetBool("StillMoving", isMoving);

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while(elapsedTime < timeToMove)
        {
            transform.position = Vector2.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
        Anim.SetBool("StillMoving", isMoving);
        ResetAnim();
    }

    //private void MoveBob(Vector3 direction)
    //{
        //transform.Translate(direction * speed * Time.deltaTime);
    //}
}
