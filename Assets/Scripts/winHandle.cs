using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winHandle : MonoBehaviour {
    public GameObject panel1;
    public GameObject panel2;
    public Button BtnOK;
    
    // Use this for initialization
    void Start () {
        BtnOK.onClick.AddListener(BtnOKOnClick);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void BtnOKOnClick()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    
}
