using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TipSpawning : MonoBehaviour
{
    
    public static int attempt = 1;
    public GameObject NoteTip;
    public GameObject TipMan;
    
    // Start is called before the first frame update
    void Start()
    {
        //attempt = 0;
        TipMan.SetActive(false);
        print(attempt);
        NoteTip.gameObject.SetActive(false);
    }

    void Update()
    {
        if (attempt % 5 == 0)
        {
            TipMan.SetActive(true);
            //NoteTip.gameObject.SetActive(true);
        }
    }

    public void CloseTheTip()
    {
        //Destroy(NoteTip);
        NoteTip.gameObject.SetActive(false);
        Time.timeScale = 1;
        //Destroy(TipMan);
        TipMan.SetActive(false);
    }

    public void ShowMeTip()
    {
        NoteTip.gameObject.SetActive(true);
        TipMan.SetActive(false);
        Time.timeScale = 0;
    }
}
