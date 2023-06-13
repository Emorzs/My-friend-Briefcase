using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject step1, step2, step3, step4, step5, step6, step7, GameOver, StepsCounter;
    //public float steps;
    public static int steps;
    
    void Start()
    {
        steps = 10; //7
        step1.gameObject.SetActive(true);
        step2.gameObject.SetActive(true);
        step3.gameObject.SetActive(true);
        step4.gameObject.SetActive(true);
        step5.gameObject.SetActive(true);
        step6.gameObject.SetActive(true);
        step7.gameObject.SetActive(true);
        GameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //StepsCounter = steps * Time.deltaTime;

        if (steps > 10) //7
            steps = 10; //7

        

        switch (steps)
        {
            case 7:
                step1.gameObject.SetActive(true);
                step2.gameObject.SetActive(true);
                step3.gameObject.SetActive(true);
                step4.gameObject.SetActive(true);
                step5.gameObject.SetActive(true);
                step6.gameObject.SetActive(true);
                step7.gameObject.SetActive(true);
                break;

            case 6:
                step1.gameObject.SetActive(true);
                step2.gameObject.SetActive(true);
                step3.gameObject.SetActive(true);
                step4.gameObject.SetActive(true);
                step5.gameObject.SetActive(true);
                step6.gameObject.SetActive(true);
                step7.gameObject.SetActive(false);
                break;

            case 5:
                step1.gameObject.SetActive(true);
                step2.gameObject.SetActive(true);
                step3.gameObject.SetActive(true);
                step4.gameObject.SetActive(true);
                step5.gameObject.SetActive(true);
                step6.gameObject.SetActive(false);
                step7.gameObject.SetActive(false);
                break;

            case 4:
                step1.gameObject.SetActive(true);
                step2.gameObject.SetActive(true);
                step3.gameObject.SetActive(true);
                step4.gameObject.SetActive(true);
                step5.gameObject.SetActive(false);
                step6.gameObject.SetActive(false);
                step7.gameObject.SetActive(false);
                break;

            case 3:
                step1.gameObject.SetActive(true);
                step2.gameObject.SetActive(true);
                step3.gameObject.SetActive(true);
                step4.gameObject.SetActive(false);
                step5.gameObject.SetActive(false);
                step6.gameObject.SetActive(false);
                step7.gameObject.SetActive(false);
                break;

            case 2:
                step1.gameObject.SetActive(true);
                step2.gameObject.SetActive(true);
                step3.gameObject.SetActive(false);
                step4.gameObject.SetActive(false);
                step5.gameObject.SetActive(false);
                step6.gameObject.SetActive(false);
                step7.gameObject.SetActive(false);
                break;

            case 1:
                step1.gameObject.SetActive(true);
                step2.gameObject.SetActive(false);
                step3.gameObject.SetActive(false);
                step4.gameObject.SetActive(false);
                step5.gameObject.SetActive(false);
                step6.gameObject.SetActive(false);
                step7.gameObject.SetActive(false);
                break;

            case 0:
                step1.gameObject.SetActive(false);
                step2.gameObject.SetActive(false);
                step3.gameObject.SetActive(false);
                step4.gameObject.SetActive(false);
                step5.gameObject.SetActive(false);
                step6.gameObject.SetActive(false);
                step7.gameObject.SetActive(false);
                break;

            case -1:
                step1.gameObject.SetActive(false);
                step2.gameObject.SetActive(false);
                step3.gameObject.SetActive(false);
                step4.gameObject.SetActive(false);
                step5.gameObject.SetActive(false);
                step6.gameObject.SetActive(false);
                step7.gameObject.SetActive(false);
                Time.timeScale = 0;
                GameOver.gameObject.SetActive(true);
                break;
        }

    }
}
