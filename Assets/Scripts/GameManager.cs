using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject UIRoot = null;
    public GameObject PoolRoot = null;
    public GameObject DispRoot = null;
    public GameObject DC = null; 

    private List<GameObject> ModelList = new List<GameObject>();
    private int CurrentPosition = 0; //目前model的位置

    void Start()
    {
        //scan UI 
        if (UIRoot != null)
        {
            int childCount = UIRoot.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject child = UIRoot.transform.GetChild(i).gameObject;
                if (child.name.Equals("BtnLeft"))
                {
                    Button button = child.GetComponent<Button>();
                    button.onClick.AddListener(BtnLeftOnClick);
                }

                if (child.name.Equals("BtnRight"))
                {
                    (child.GetComponent<Button>())
                        .onClick
                        .AddListener(BtnRightOnClick);
                }

                if (child.name.Equals("BtnBack"))
                {
                    (child.GetComponent<Button>())
                        .onClick
                        .AddListener(BtnBackOnClick);
                }
                if (child.name.Equals("BtnMM"))
                {
                    Button button = child.GetComponent<Button>();
                    button.onClick.AddListener(BtnMMOnClick);
                }


            }
        }


        //scan pool root ,put model into list
        if (PoolRoot != null)
        {
            int childCount = PoolRoot.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                ModelList.Add(PoolRoot.transform.GetChild(i).gameObject);
            }
        }

        Display();

    }

   

    private void Display()
    {
        foreach (GameObject g in ModelList)
        {
            g.transform.parent = PoolRoot.transform; //all reset
        }
        ModelList[CurrentPosition].transform.parent = DispRoot.transform; //瞬移
        //ModelList[CurrentPosition].transform.localPosition = Vector3.zero; //reset
    }
    public void BtnLeftOnClick()
    {
        Debug.Log("BtnLeftOnClick");

        CurrentPosition--;
        if (CurrentPosition < 0)
        {
            CurrentPosition = 0;
        }
        Display();
    }
    public void BtnRightOnClick()
    {
        Debug.Log("BtnRightOnClick");

        CurrentPosition++;
        if (CurrentPosition >= ModelList.Count)
        {
            CurrentPosition = ModelList.Count - 1;
        }
        Display();
    }

    public void BtnBackOnClick()
    {
        Debug.Log("BtnBackOnClick");
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
    public void BtnMMOnClick()
    {
        Debug.Log("BtnMMOnClick");
        SceneManager.LoadScene("IDKScene", LoadSceneMode.Single);
    }

}
