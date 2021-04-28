using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float remainingTime = 90; //time in seconds
    public Text timeText;
    public GameObject mainCamera;
    public GameObject player;
    public GameObject youWin;
    public float restartDelay = 2f;

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
            //Debug.Log("Game Over");
            //mainCamera.SetActive(true);
            //Destroy(this.player);


        }
        DisplayTime(remainingTime);
    }
    void DisplayTime(float displayedTime)
    {
        if (remainingTime < 0)
        {
            remainingTime = 0;
            Debug.Log("Game Over 1");
            FindObjectOfType<GameManager>().EndGame();
            mainCamera.SetActive(true);
            youWin.SetActive(true);
            Destroy(this.player);
            Invoke("Restart", restartDelay);

        }
        else
        {
            //Debug.Log("Game Over");
        }

        float minute = Mathf.FloorToInt(remainingTime / 60);
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minute, seconds);
    }
}
