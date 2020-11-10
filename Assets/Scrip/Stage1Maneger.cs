using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1Maneger : MonoBehaviour
{
    [Header("QuitButton")]
    public Button QuitB;
    public Button WinMainMenuB;
    public Button WinQuitB;
    [Header("Slider")]
    public Slider MusicS;
    [Header("Audio")]
    public AudioSource GameBGM;
    [Header("TimeCounter")]
    public Text TimeT;

    private int time = 0;

    void Start()
    {
        QuitB.onClick.AddListener(MainMenu);
        WinMainMenuB.onClick.AddListener(MainMenu);
        WinQuitB.onClick.AddListener(QuitGame);
        InvokeRepeating("Timer", 1, 1);
    }

    void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void QuitGame()
    {
        Application.Quit();
    }

    void Timer()
    {
        time++;
        TimeT.text = time.ToString();
    }

    void Update()
    {
        GameBGM.volume = MusicS.value;
        
    }
}
