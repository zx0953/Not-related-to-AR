using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tryHandle : MonoBehaviour {
    public Button BtnMenu;
    public Button BtnTry;

    // Use this for initialization
    void Start () {
        BtnMenu.onClick.AddListener(BtnMenuOnClick);
        BtnTry.onClick.AddListener(BtnTryOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void BtnMenuOnClick()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
    void BtnTryOnClick()
    {
        SceneManager.LoadScene("IDKScene", LoadSceneMode.Single);
    }
}
