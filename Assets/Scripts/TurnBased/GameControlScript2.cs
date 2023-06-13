using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;
//using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class GameControlScript2 : MonoBehaviour
{
    //Временно добавил ниже Victory. Потом его надо убрать!
    public GameObject GameOver;
    //public GameObject Victory;
    //public int steps;
    //public Text StepsCounter;
    public TextMeshProUGUI StepsCounter;
    public static int steps;
    public int steper;

    public static int blue;
    public static int yellow;
    public static int red;

    //private void Awake()
    //{
    //StepsCounter= GetComponent<TextMeshProUGUI>();
    //}

    void Start()
    {
        blue = 0;
        yellow = 0;
        red = 0;
        steps = steper;
        GameOver.gameObject.SetActive(false);
        Time.timeScale = 1;
        //Victory.gameObject.SetActive(false);
        //StepsCounter = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        StepsCounter.text = steps.ToString();

        if(steps == 0 && Hero1Movement.isMoving == false)
        {

        Time.timeScale = 0;
        GameOver.gameObject.SetActive(true);
        }

        if (steps == -1)
        {
            steps = 0;
            Time.timeScale = 0;
            GameOver.gameObject.SetActive(true);
        }
    }
}
