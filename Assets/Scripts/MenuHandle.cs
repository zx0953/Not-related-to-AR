using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHandle : MonoBehaviour {
    public Button BtnStart;
    public Button BtnExit;
	// Use this for initialization
	void Start () {
        BtnStart.onClick.AddListener(BtnStartOnClick);
        BtnExit.onClick.AddListener(BtnExitOnClick);
    }

    

    // Update is called once per frame
    void Update () {
		
	}
    void BtnStartOnClick()
    {
        Debug.Log("BtnStartOnClick");
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
    void BtnExitOnClick()
    {
        Debug.Log("BtnExitOnClick");
        Application.Quit();
    }
}
