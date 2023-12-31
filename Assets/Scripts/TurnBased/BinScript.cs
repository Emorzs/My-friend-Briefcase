using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinScript : MonoBehaviour
{
    public GameObject List;
    public GameObject ClearTrash;
    public GameObject FilledTrashCan;

    //���� ��������� �����
    [SerializeField] private AudioClip _binsound;

    private void Start()
    {
        List.SetActive(false);
        FilledTrashCan.SetActive(false);
        //���� ������� ����������� ������� ����
        //FilledTrashCan = GetComponent<GameObject>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(GameControlScript2.red > 0)
        {
            //GameControlScript2.red += 1;
            GameControlScript2.red -= 1;
            //���� BinSound2
            SoundManager.instance.PlaySound(_binsound);
            ClearTrash.SetActive(false);
            List.SetActive(true);
            FilledTrashCan.SetActive(true);
            Destroy(gameObject);
            //��������� �������� ���������� red
            //print(GameControlScript2.red);
        }
        
    }
}
