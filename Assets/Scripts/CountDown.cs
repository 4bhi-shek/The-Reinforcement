using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float timeValue = 120;
    public Text timeText;

    private void Update()
    {
        Timer();
    }

    public void Timer()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue += 120;
        }

        DisplayTime(timeValue);
    }

    public void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay<1)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
