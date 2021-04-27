using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float remainingTime = 90; //time in seconds
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime >= 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else
        {
            remainingTime = 0;

        }
        DisplayTime(remainingTime);
    }
    void DisplayTime(float displayedTime)
    {
        if (remainingTime < 0)
        {
            remainingTime = 0;
        }
        float minute = Mathf.FloorToInt(remainingTime / 60);
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minute, seconds);
    }
}
