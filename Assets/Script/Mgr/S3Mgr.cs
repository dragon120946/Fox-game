using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class S3Mgr : MonoBehaviour
{
   public List<Image> ImageList;
    
    //分數
    public Text scoreText;

    //暫停
    public Button btnPause;   

    //勝利視窗
    public GameObject winRestart, winQuit, win;
    public Button btnWinRestart, btnWinQuit;
    
    //失敗視窗
    public GameObject loseRestart, loseQuit, lose;
    public Button btnLoseRestart, btnLoseQuit;
    
    //暫停視窗
    public GameObject coutiune, pause,pauseText;
    public Button btnCoutiune;

    private bool isDeath;
    private bool isWin = false, isLose = false;

    void Start()
    {
        GameManager.score = 10;
        
        Time.timeScale = 1;
        isDeath = false;
        
        GameManager.HP = 8;
        
        //每死一次 血量上限-1 ( 還做不到 )
        /*
        if (isDeath)
        {
            isDeath = false;
            GameManager.HP--;
        }
        */

        //隱藏勝利視窗
        winRestart.SetActive(false);
        winQuit.SetActive(false);
        win.SetActive(false);
        
        //隱藏死亡視窗
        loseRestart.SetActive(false);
        loseQuit.SetActive(false);
        lose.SetActive(false);
        
        //隱藏暫停視窗
        pause.SetActive(true);
        coutiune.SetActive(false);
        pauseText.SetActive(false);
        
        btnWinRestart.onClick.AddListener(OnbtnWinRestartClick); 
        btnWinQuit.onClick.AddListener(OnbtnQuitClick);
        btnLoseRestart.onClick.AddListener(OnbtnLoseRestartClick);
        btnLoseQuit.onClick.AddListener(OnbtnQuitClick);
        btnPause.onClick.AddListener(OnbtnPauseClick);
        btnCoutiune.onClick.AddListener(OnbtnCoutinueClick);
    }

    /*
    void OnGUI()
    {
        if(GUI.Button(new Rect(0, 0, 100, 100), "BACK"))
        {
            SceneManager.LoadScene("S2");
        }
    }
    */

    void Update()
    {
        //扣血圖示
        for (int i = 0; i < 8; i++)     
        {
            if (i > GameManager.HP - 1)
            {
                ImageList[i].gameObject.SetActive(false);
            }
            else
            {
                ImageList[i].gameObject.SetActive(true);
            }
        }
        
        //30分跳出勝利視窗
        if (GameManager.score == 30)
        {
            Time.timeScale = 0;
            
            win.SetActive(true);
            winRestart.SetActive(true);
            winQuit.SetActive(true);
            
            pause.SetActive(false);
        }
        
        //HP小於０跳出失敗視窗
        if(GameManager.HP <= 0)
        {
            Time.timeScale = 0;
            
            isDeath = true;

            lose.SetActive(true);
            loseRestart.SetActive(true);
            loseQuit.SetActive(true);
            
            pause.SetActive(false);
        }

        scoreText.text = "Score: " + GameManager.score;
    }

    //勝利按鈕
    void OnbtnWinRestartClick()
    {
        SceneManager.LoadScene("S2");
    }
    
    //退出按鈕
    void OnbtnQuitClick()
    {
        Application.Quit();
    }
    
    //失敗按鈕
    void OnbtnLoseRestartClick()
    {
        SceneManager.LoadScene("S3");
    }
    
    //暫停按鈕
    void OnbtnPauseClick()
    {
        Time.timeScale = 0;
        
        pauseText.SetActive(true);
        coutiune.SetActive(true);
        pause.SetActive(false);
    }
    
    //繼續按鈕
    void OnbtnCoutinueClick()
    {
        Time.timeScale = 1;
        
        pause.SetActive(true);
        coutiune.SetActive(false);
        pauseText.SetActive(false);
    }
}
