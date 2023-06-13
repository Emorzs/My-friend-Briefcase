using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //print("Yes, it works");
            Time.timeScale = 1;
            //— –»œ“ Õ¿ —Œ¬≈“€◊¿
            TipSpawning.attempt += 1;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    //public void ResetTheGame()
    //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //print("Yes, it works");
    //}
}
