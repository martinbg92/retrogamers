using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    [SerializeField] private GameObject FINNIVEL;

    public float timeRemaining = 10;
    private bool timerIsRunning;
    private void Start()

    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    private void Stop()
    {
        // Starts the timer automatically
        timerIsRunning = false;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Time.timeScale = 0f;
            FINNIVEL.SetActive(true);
        }
    }
}
