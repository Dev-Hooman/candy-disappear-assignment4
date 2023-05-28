using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    [SerializeField]public Text timerText;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public const float MAX_TIME = 30.0f;
    float timer = 30.0f;
    void Update()
    {
        timer -= Time.deltaTime;

        timerText.text = "Time: " + (int)timer + ":00";

        if (timer < 0)
        {
            SceneManager.LoadScene("GameOver");

            // call for game over

        }
    }
}
