using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictorySctipt : MonoBehaviour
{
    public GameObject Victory;
    public GameObject[] Lists;

    private void Start()
    {
        Victory.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //print(col.gameObject.name);

        if (IsAllLists())
        {
            //print("Victory");
            //Victory.gameObject.SetActive(true);
            Time.timeScale = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
            //ДЛЯ Обнуления счётчика ПОДСКАЗОК
            TipSpawning.attempt = 1;

        }
    }

    bool IsAllLists()
    {
        int alllists = 0;
        foreach (GameObject list in Lists)
        {
            if (list.activeSelf == true)
            {
                alllists++;
            }
        }

        //print (alllists);
        //print(Lists.Length);
        if (alllists == Lists.Length) return true;
        else return false;
    }
}
