using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject panelPauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PanelPauseMenu();
        }
    }

    public void PanelPauseMenu()
    {
        panelPauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeBTN()
    {
        panelPauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenuBTN()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
