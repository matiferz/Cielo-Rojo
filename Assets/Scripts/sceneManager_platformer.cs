using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager_platformer : MonoBehaviour
{
    public GameObject deactivateObj;

    void Start()
    {
        //Aplicar script de la resolución
        Screen.SetResolution(1920, 1080, true);
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Restart();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Exit();
        }
        if (Input.GetKey(KeyCode.P))
        {
            Pause();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    void Pause()
    {
        Time.timeScale = 0;
        deactivateObj.SetActive(true);
    }

    void Exit()
    {
        Application.Quit();
    }

     public void Resume()
    {
        Time.timeScale = 1;
        deactivateObj.SetActive(false);
    }
}

