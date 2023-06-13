using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicNonstop : MonoBehaviour
{
    public static MusicNonstop instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }




        /*GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(this.gameObject);*/
    }
    /*private void OnEnable()
    {
        print(SceneManager.GetActiveScene().buildIndex);
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(this.gameObject);
        }
    }*/
}
