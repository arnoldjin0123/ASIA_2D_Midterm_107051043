using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterTouchEvent : MonoBehaviour
{
    public GameObject Winpage;
    public GameObject GoalParticle;
    public GameObject Goal;
    public Text PineT;
    public AudioSource GoalAudio;
    public AudioSource BGMAudio;

    private int Pineappleval = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pineapple")
        {
            Pineappleval++;
            Destroy(collision.gameObject);
            PineT.text = Pineappleval.ToString() + "/20";
        }

        if (collision.tag == "Goal")
        {
            Winpage.SetActive(true);
            BGMAudio.Pause();
            Time.timeScale = 0f;
        }

        {
        }
        if (PineT.text == "20/20")
        {
            GoalAudio.Play(0);
            Goal.SetActive(true);
            GoalParticle.SetActive(true);
        }
    }
}
