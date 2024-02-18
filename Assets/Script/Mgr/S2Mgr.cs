using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S2Mgr : MonoBehaviour
{

    public Button btnStart;
    public Button btnQuit;
    
    void Start()
    {
        btnStart.onClick.AddListener(OnbtnStartClick);
        btnQuit.onClick.AddListener(OnbtnQuitClick);
    }
    
    void Update()
    {
        
    }

    public void OnbtnStartClick()
    {
       // Debug.Log("HelloWorld");
        SceneManager.LoadScene("S1");
    }

    void OnbtnQuitClick()
    {
        Application.Quit();
    }
}
