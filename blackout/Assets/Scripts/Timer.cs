using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timevalue = 180;
    public Text timeText;

    void Update()
    {
        if (timevalue > 0)
        {
            timevalue -= Time.deltaTime;
        }
        else
        {
            timevalue = 0;
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);

        }
        DisplayTime(timevalue);
    }

    void DisplayTime(float timeDisplay)
    {
        if (timeDisplay < 0)
        {
            timeDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}

