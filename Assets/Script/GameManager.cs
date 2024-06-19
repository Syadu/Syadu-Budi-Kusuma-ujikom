using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float totalTime = 60f;
    private float timeRemaining;
    public Text timerText;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = totalTime;
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            timeRemaining = 0;
            ShowGameOverPanel();
        }
    }

    public void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int second = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, second);
    }

    public void ShowGameOverPanel()
    {
        timerText.gameObject.SetActive(false);
        gameOverPanel.SetActive(true);
    }
}
