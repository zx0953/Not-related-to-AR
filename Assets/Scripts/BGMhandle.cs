using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMhandle : MonoBehaviour {
    AudioSource m_MyAudioSource;
    private void Awake()
    {
        if (StaticVar.isBGMready)
        {
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);  //自殺
        }
        else
        {
            StaticVar.isBGMready = true; //標記變數
            DontDestroyOnLoad(this);  //標記永不銷毀 (直到APP EXIT)
        }
    }



    // Use this for initialization
    void Start () {
        m_MyAudioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        int y = SceneManager.GetActiveScene().buildIndex;
        if (y ==2)
        {
            m_MyAudioSource.Pause();
        }
        else
        {
            m_MyAudioSource.UnPause();
        }
	}
}
