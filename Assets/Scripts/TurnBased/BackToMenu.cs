using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{

    private void Start()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
    }
    public void LoadMainMenu()
    {
        print("BACK TO MENUUUU!!!");
        Destroy(MusicNonstop.instance.gameObject);
        SceneManager.LoadScene("Menu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
