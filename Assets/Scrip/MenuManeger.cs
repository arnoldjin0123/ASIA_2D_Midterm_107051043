using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManeger : MonoBehaviour
{
    [Header("Start&Quit button")]
    public Button StartB;
    public Button QuitB;

    void Start()
    {
        StartB.onClick.AddListener(StartGame);
        QuitB.onClick.AddListener(EndGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void EndGame()
    {
        Application.Quit();
    }
}
